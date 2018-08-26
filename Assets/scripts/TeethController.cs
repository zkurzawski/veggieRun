// TeethController.cs 
// Veggie Run script written in C#
// Zakary Kurzawski 2016
// Controls the movement of the Teeth game object as well as scene change
// after five hits of candy assets. Upon trigger event with candy, the 
// teeth object farthest to the right of the screen in the health meter
// will gain a rigidbody and fall to the destructor at the bottom of the screen.

using UnityEngine;
using System.Collections;

public class TeethController : MonoBehaviour {

	private AudioSource bite;
	private AudioSource glass;
	public SceneManager sceneManager;
	public float jumpForce;
	public float runForce;
	public Rigidbody2D rb;
	public Transform groundCheck;
	public LayerMask groundDefined;
	public float groundRadius;
	private bool isPaused = false;
	private bool onGround = true;
	public GameObject[] teethMeter;
	private int teethCount = 5;
	private float timeGap = 0.0F;

	void Start () {
		rb=GetComponent<Rigidbody2D>();
		AudioSource[] audioSource = GetComponents<AudioSource>();
		bite = audioSource[0];
		glass = audioSource[1];
		AudioListener.pause = false;
	}

	// Load "Game Over" screen after five trigger events with candy assets
	IEnumerator changeScene(){
		yield return new WaitForSeconds(1);
		sceneManager.LoadScene("GameOver");
	}

	// Add rigidbody to health meter asset and play trigger sounds (glass breaking or crunch)
	void OnTriggerEnter2D (Collider2D col){
		if (col.gameObject.tag == "candy"){
			glass.Play();
			teethMeter[teethCount - 1].AddComponent<Rigidbody2D>();
			teethCount--;
		}
		if (col.gameObject.tag == "vegetable"){
			bite.Play();
		}
		if (teethCount == 0){
			StartCoroutine(changeScene());
		} 
	}

	void FixedUpdate() {
		onGround = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundDefined);
	}

	// Move player character forward toward the right of the screen. Speed to be determined within the unity editor
	// Define jump, pause and quit keypresses.
	void Update () {

		rb.velocity = new Vector2(runForce * Time.deltaTime, rb.velocity.y);

		if (runForce <= 800){
			if (Time.time >= timeGap + 5.0F){
				runForce = runForce + 5;
				timeGap = Time.time;
			}
		}

		if (Input.GetKeyDown(KeyCode.Space) && onGround)
			rb.velocity = new Vector2(rb.velocity.x,jumpForce);

		if (Input.GetKeyDown(KeyCode.P) && isPaused == false){
			isPaused = true;
			AudioListener.pause = true;
		} else {
			if (isPaused == true && Input.GetKeyDown(KeyCode.P)){
				isPaused = false;
				AudioListener.pause = false;
			}
		}

		if (Input.GetKeyDown(KeyCode.Q)){
			sceneManager.LoadScene("TitleScreen");
			AudioListener.pause = false;
		}
		
		if (isPaused == true){
			Time.timeScale = 0.0f;
		} else {
			Time.timeScale = 1.0f;
		}
		
	}

}

// FoodController.cs 
// Veggie Run script written in C#
// Zakary Kurzawski 2016
// Controlls the movement of food elements (candy and vegetables).
// Also sets the destruction trigger for food elements upon collision with the Teeth element.

using UnityEngine;
using System.Collections;

public class FoodController : MonoBehaviour {

	public Rigidbody2D rb;
	public float runForce;

	void Start () {
	
	}

	// Apply movement to food objects in the game.
	void Update () {
		rb.velocity = new Vector2(runForce * Time.deltaTime, rb.velocity.y);
	}

	// Destroy food object upon collision with player character
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Player"){
			Destroy(gameObject);
		}
	}
}
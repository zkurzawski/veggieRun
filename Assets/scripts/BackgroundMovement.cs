// BackgroundMovement.cs 
// Veggie Run script written in C#
// Zakary Kurzawski 2016
// Controls the movement of background objects across the screen.
// Speed of objects to be defined by assigning value to the assetSpeed variable in the Unity environment. 
// Negative values will move object from right to left.

using UnityEngine;
using System.Collections;

public class BackgroundMovement : MonoBehaviour {

	public Rigidbody2D rb;
	public float assetSpeed;

	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
		rb.velocity = new Vector2(assetSpeed * Time.deltaTime , rb.velocity.y);
	}
}

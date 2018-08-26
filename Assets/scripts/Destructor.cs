// Destructor.cs 
// Veggie Run script written in C#
// Zakary Kurzawski 2016
// Create triggers to destroy game elements to free up memory space.

using UnityEngine;
using System.Collections;

public class Destructor : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.transform.parent)
		{
			Destroy(other.gameObject.transform.parent.gameObject);
		}	
		else 
		{
			Destroy(other.gameObject);
		}
	} 
}

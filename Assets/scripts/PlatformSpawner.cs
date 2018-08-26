// PlatformSpawner.cs 
// Veggie Run script written in C#
// Zakary Kurzawski 2016
// Spawns ground continuously from spawn points defined within the Unity environment.

using UnityEngine;
using System.Collections;

public class PlatformSpawner : MonoBehaviour {

	public GameObject platform;
	public Transform spawnMarker;

	private float platformLength;

	// Assign the platform length based on box collider set within the Unity environment
	void Start () {
		platformLength = platform.GetComponent<BoxCollider2D>().size.x;
	}

	// Moves the platform spawner and places a new platform.
	void Update () {

		if (transform.position.x < spawnMarker.position.x)
		{
			transform.position = new Vector3(transform.position.x + platformLength, transform.position.y, transform.position.z);
			Instantiate (platform, transform.position, transform.rotation);
		}	
	}
	
}

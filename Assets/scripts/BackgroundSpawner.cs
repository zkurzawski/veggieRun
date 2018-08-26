// BackgroundSpawner.cs 
// Veggie Run script written in C#
// Zakary Kurzawski 2016
// Spawn background objects (trees and clouds).
// Spawn gaps will be defined from within the Unity environment.

using UnityEngine;
using System.Collections;

public class BackgroundSpawner : MonoBehaviour {

	public Transform assetSpawnPoint;

	public GameObject[] asset;
	public float timeGap;
	private float spawnTime = 0.0F;
	private int assetNum = 0;
	public int assetCount;

	void FixedUpdate () {
		if (Time.time > spawnTime + timeGap){
			assetNum = Random.Range(0, assetCount);
			spawnTime = Time.time;

			Instantiate (asset[assetNum], assetSpawnPoint.position, assetSpawnPoint.rotation);
		}
	}
}

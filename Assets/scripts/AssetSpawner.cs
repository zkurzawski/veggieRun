// AssetSpawner.cs 
// Veggie Run script written in C#
// Zakary Kurzawski 2016
// Generates assets (candies and vegetables) in Veggie Run game.
// Assets are spawned randomly and the frequency at which they spawn becomes
// shorter approximately every 900 frames.

using UnityEngine;
using System.Collections;

public class AssetSpawner : MonoBehaviour {

	public Transform assetSpawnPoint;
	private float timeGap = 5.0F;
	private float spawnTime = 0.0F;
	public GameObject[] asset;
	private int assetNum = 0;
	private float timeGapControl = 0.0F;

	void Start () {
	}
	
	void Update () {

		if (timeGap > 1.0F){
			if (Time.time >= timeGapControl + 15.0F){
				timeGap = timeGap - 0.5F;
				timeGapControl = Time.time;
			}
		}
		if (Time.time > spawnTime + timeGap)
		{
			assetNum = Random.Range(0,7);
			spawnTime = Time.time;
			Instantiate (asset[assetNum], assetSpawnPoint.position, assetSpawnPoint.rotation);
		}
	}
}

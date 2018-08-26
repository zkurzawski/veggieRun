// MusicPlayer.cs 
// Veggie Run script written in C#
// Zakary Kurzawski 2016
// Initialize background music and make it continue through each scene uninteruppted.

using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	static MusicPlayer instance = null;

	void Start () {
		if (instance != null){
			Destroy (gameObject);
		} else{
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}

	void Update () {
	
	}
}

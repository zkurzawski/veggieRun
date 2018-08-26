// SceneManager.cs 
// Veggie Run script written in C#
// Zakary Kurzawski 2016
// Loads the different scenes of the game.

using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

	public void LoadScene (string name) {
		Application.LoadLevel(name);
	}

}

// CameraController.cs 
// Veggie Run script written in C#
// Zakary Kurzawski 2016
// Locks the camera to the Teeth element's position on the x-axis.

using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	public Transform character;
	public float cameraDisplacement;

	void Update () {
		transform.position = new Vector3(character.position.x + cameraDisplacement,0,-10);
	}
}

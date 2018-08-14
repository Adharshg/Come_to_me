using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontroller : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	public bool Rotatearoundplayer = true;

	public float RotationSpeed = 5.0f;
	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if(Rotatearoundplayer){
			Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * RotationSpeed, Vector3.up);

			offset = camTurnAngle * offset;
		}
		transform.position = player.transform.position + offset;
	}
}

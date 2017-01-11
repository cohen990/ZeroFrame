using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.lockCursor = true;
	}
	
	// Update is called once per frame
	void Update () {
		var speed = 0.1f;
		var lookSpeed = 1f;
		var player = GameObject.FindGameObjectsWithTag ("Player")[0];
		if (Input.GetKey (KeyCode.A)) {
			player.transform.Translate(new Vector3(-speed,0.0f,0.0f));
		}
		if (Input.GetKey (KeyCode.D)) {
			player.transform.Translate(new Vector3(speed,0f,0f));
		}
		if (Input.GetKey (KeyCode.W)) {
			player.transform.Translate(new Vector3(0f,0f,speed));
		}
		if (Input.GetKey (KeyCode.S)) {
			player.transform.Translate(new Vector3(0f,0f,-speed));
		}
		player.transform.Rotate(new Vector3(0, Input.GetAxis ("Mouse X") * lookSpeed,0));
		player.transform.Rotate(new Vector3(Input.GetAxis ("Mouse Y") * lookSpeed,0,0));
		player.transform.rotation = Quaternion.Euler (player.transform.rotation.eulerAngles.x, player.transform.rotation.eulerAngles.y, 0);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterControl : MonoBehaviour {

	public CharacterController2D controller;

	public float runSpeed = 40f;
	public float bulletSpeed = 20f;
	float horizontalMove = 0f;
	bool jump = false; 

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		horizontalMove = Input.GetAxisRaw ("Horizontal") * runSpeed;
		Debug.Log (Input.GetButtonDown ("Horizontal"));
		//Debug.Log (Input.GetButtonDown ("Jump"));
		if (Input.GetButtonDown ("Jump")) {
			jump = true;
		}
	}

	void FixedUpdate () {
		Debug.Log ("hor" + horizontalMove);
		controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
		jump = false;
		if (Input.GetKeyDown (KeyCode.Space)) {
			controller.Fire();
		}
	}

//	void Fire( float direction) {
//		// Create the Bullet from the Bullet Prefab
//		var bullet = (GameObject)Instantiate (
//			bulletPrefab,
//			bulletSpawn.position,
//			bulletSpawn.rotation);
//		//Debug.Log ("fdsfds " + bullet);
//		// Add velocity to the bullet
//		if (direction < 0) {
//			bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.right * -bulletSpeed;
//		} else {
//			bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.right * bulletSpeed;
//		}
//
//
//		// Destroy the bullet after 2 seconds
//		Destroy(bullet, 1.5f);
//	}
}

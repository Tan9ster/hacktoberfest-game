using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handMove : MonoBehaviour {

	public GameObject target;
	public float moveSpeed = 5; //move speed
	public float rotationSpeed = 5; //speed of turning
	private Rigidbody2D rb;
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}
	void Update()
	{
//		//rotate to look at the player
//		transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.transform.position - transform.position), rotationSpeed * Time.deltaTime);
//		//move towards the player
//		transform.position += transform.forward * Time.deltaTime * moveSpeed;
		Follow();
	}

	void Follow() {
		Vector3 vectorToTarget = target.transform.position - transform.position;
		transform.position += vectorToTarget.normalized * moveSpeed * Time.deltaTime;
	}
}

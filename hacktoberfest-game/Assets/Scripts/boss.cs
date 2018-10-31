using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour {

	public GameObject fist1;
	public GameObject fist2;
	public GameObject fist3;
	public GameObject fist4;
	public GameObject fist5;
	public GameObject fist6;
	public GameObject face;

	public float speed = 400;

	private float randX;
	private float randY;
	private Vector2 direction; 

	private Rigidbody2D rb;
	private float health = 100; 

//	enum bossPhase {
//		phase1,
//		phase2,
//		phase3
//	}

	// Use this for initialization
	void Start () {
		direction = new Vector2 (0, -1);
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = direction * Time.deltaTime*speed;
	}
	
	// Update is called once per frame
	void Update () {
		//random vector 
//		randX = Random.Range(-10.0f, 10.0f);
//		randY = Random.Range(-10.0f, 10.0f);
//		direction = new Vector2(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f));
//		direction.Normalize ();
		rb.velocity = direction*Time.deltaTime*speed;
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "walls") {
			direction = new Vector2(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f));
			direction.Normalize ();
		}
	}
}

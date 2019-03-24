using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 1f;

	void Start () {
		
	}
	
	void Update () {
		if (Input.GetKey(KeyCode.W))
		{
			transform.Translate(transform.forward * speed);
		}
		if (Input.GetKey(KeyCode.S))
		{
			transform.Translate(transform.forward * -speed);
		}
		if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(transform.right * -speed);
		}
		if (Input.GetKey(KeyCode.D))
		{
			transform.Translate(transform.right * speed);
		}
		if (Input.GetKey(KeyCode.Space))
		{
			Shoot();
		}
	}

	void Shoot()
	{
	}
}

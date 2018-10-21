using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowFruit : MonoBehaviour {

	public Rigidbody rb;
	double timer = 0.0;
	public int force = 1000;

	void FixedUpdate() {
		rb = GetComponent<Rigidbody>();
		timer += Time.deltaTime;
		if (timer > 5){
			if(force < 5000)
			{
				force += 1000;
			}
			timer = 0.0;
		}
		// rb.AddForce(force * Time.deltaTime,500 * Time.deltaTime,0);
		rb.AddForce(force * Time.deltaTime * 2, 0, 0);
	}
}

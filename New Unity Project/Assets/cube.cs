using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		// moveSpeed = 1f;
	}

	// Update is called once per frame
	void Update ()
	{
		transform.Translate(8f*Input.GetAxis("Horizontal")*Time.deltaTime, 0f, 8f*Input.GetAxis("Vertical")*Time.deltaTime);
	}
}

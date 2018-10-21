using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnContact : MonoBehaviour {

	// // Use this for initialization
	// void Start () {
	//
	// }
	//
	// // Update is called once per frame
	// void Update () {
	//
	// }

	void onTriggerEnter(Collision col)
	{
		if(col.gameObject.name == "Cube")
		{
			Destroy(col.gameObject);
		}
	}

	void onCollisionEnter(Collision col)
	{
		// if(col.gameObject.name == "Pumpkin")
		// {
		if(col.collider.tag == "Collider")
		{
			Destroy(col.gameObject);
		}
		// }
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followObject : MonoBehaviour {

	public Vector3 myPos;
	public Transform myPlay;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	public void Update()
	{
		transform.position = myPlay.position - myPos;
	}
}

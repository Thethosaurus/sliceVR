using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatermelonSpawner : MonoBehaviour {

	public Rigidbody Somethingprefab;
	public Vector3 center;
	public Vector3 size;
	public double timer = 0.0;

	// Use this for initialization
	void Start () {
		//SpawnFruit();
	}


	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > 1.6) {
			SpawnFruit();
			timer = 0;
		}
	}

	public void SpawnFruit() {
		Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y/2, size.y/2), Random.Range(-size.z/2, size.z/2));
		Instantiate (Somethingprefab, pos, Quaternion.Euler(270,270,0));
	}

	void OnDrawGizmosSelected() {
		Gizmos.color = new Color(1, 0, 0, 0.5f);
		Gizmos.DrawCube(center, size);
	}

}

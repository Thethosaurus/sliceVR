using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	
	public float timer;
	public Text scoreText;

	void Update() {
    		timer += Time.deltaTime;
    		string minutes = Mathf.Floor(timer / 60).ToString("00");
     		string seconds = (timer % 60).ToString("00");
     		scoreText.text = string.Format("{0}:{1}", minutes, seconds);
 	}
}

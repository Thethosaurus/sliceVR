using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectButton : MonoBehaviour {

	// Use this for initialization
	Camera m_FirstCamera;
	void Start () {
		m_FirstCamera = Camera.main;
	}

	// Update is called once per frame
	public void Update( )
{
		bool test = Input.GetKeyDown("joystick button 0");
		if(test)
		{
				Debug.Log( "Get Key Working" );
				// Debug.Log("Pixel width :" + Camera.main.pixelWidth + " Pixel height : " + Camera.main.pixelHeight);
				Debug.Log("Pixel width :" + m_FirstCamera.pixelWidth + " Pixel height : " + m_FirstCamera.pixelHeight);

		}
}
}

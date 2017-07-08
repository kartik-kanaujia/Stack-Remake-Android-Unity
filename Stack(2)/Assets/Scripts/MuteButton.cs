using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteButton : MonoBehaviour {

	private Camera cam;
	private AudioSource aud;
	// Use this for initialization
	void Start () 
	{
		cam = GetComponent<Camera> ();
		aud = GameObject.FindGameObjectWithTag ("MM").GetComponent<AudioSource>();
	}

	public void Mute()
	{
		aud.enabled = false;
	}

	public void Unmute()
	{
		aud.enabled = true;
	}

	// Update is called once per frame
	void Update () {
		
	}
}

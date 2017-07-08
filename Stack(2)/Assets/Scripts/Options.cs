using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour {

	private AudioSource aud;
	public GameObject muteButton;
	public GameObject UnMuteButton;

	private int a;


	// Use this for initialization
	void Start () 
	{
		aud = GameObject.FindGameObjectWithTag ("MM").GetComponent<AudioSource>();
//		muteButton = GameObject.FindGameObjectWithTag ("Mute");
//		UnMuteButton = GameObject.FindGameObjectWithTag ("UnMute");
	}

	public void MuteButtons()
	{
		if (aud.enabled == true)
		{
			muteButton.gameObject.SetActive (true);
			UnMuteButton.gameObject.SetActive (false);
		}
		else if(aud.enabled == false)
		{
			UnMuteButton.gameObject.SetActive (true);
			muteButton.gameObject.SetActive (false);
		}
	}

	// Update is called once per frame
	void Update () 
	{
//		if (aud.enabled == true)
//		{
//			a = 1;
//		}
//		else if(aud.enabled == false)
//		{
//			a = 0;
//		}
	}
}

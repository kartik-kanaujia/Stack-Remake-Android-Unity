using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class DontDestroy : MonoBehaviour {

//	public Sprite orange;
//	public Sprite blue;
//	public Sprite lightblue;
//	public Sprite darkblue;
//	public Sprite pink;

//	private Sprite rend;

//	private Animator animator;

	private AudioSource aud;

//	public AudioClip All;
//	public AudioClip DarkBlue;

	public float fadeRate = 0.1f;
//	void Awake () 
//	{
//		DontDestroyOnLoad (gameObject);
//	}

	void Awake () {
		DontDestroyOnLoad (this);

		if (FindObjectsOfType (GetType ()).Length > 1)
		{
			Destroy (gameObject);
		}
//		rend = GetComponent<SpriteRenderer> ().sprite;

		aud = GetComponent<AudioSource> ();

	}

//	public void FadeSound()
//	{
//		if (fadeTime == 0)
//		{
//			aud.volume = 0;
//			return;
//		}
//		StartCoroutine (FadeSounds);
//	}
//
//	IEnumerator FadeSounds()
//	{
//		float t = fadeTime;
//		while (t > 0)
//		{
//			yield return null;
//			t -= Time.deltaTime;
//			aud.volume = t / fadeTime;
//		}
//		yield break;
//	}
//	void Start ()
//	{
//		animator = GetComponent<Animator> ();
//
//
//	}

	void Update()
	{
//		if (SceneManager.GetActiveScene().name == "First")
//		{
//			StartCoroutine (ExecuteAfterTime (1f));
//
//			//animator.SetBool ("up",true);
//		}
		if (SceneManager.GetActiveScene().name == "Menu")
		{
			aud.volume += fadeRate * Time.deltaTime * 8;
			if (aud.volume > 0.9)
			{
				aud.volume = 0.9f;
			}
		}
		if (SceneManager.GetActiveScene().name == "Game")
		{
			aud.volume -= fadeRate * Time.deltaTime * 5;
			if (aud.volume < 0.1)
			{
				aud.volume = 0.1f;
			}
		}
		if (SceneManager.GetActiveScene().name == "Menu 1")
		{
			aud.volume += fadeRate * Time.deltaTime * 8;
			if (aud.volume > 0.9)
			{
				aud.volume = 0.9f;
			}
		}
		if (SceneManager.GetActiveScene().name == "Game 1")
		{
			aud.volume -= fadeRate * Time.deltaTime * 5;
			if (aud.volume < 0.1)
			{
				aud.volume = 0.1f;
			}
		}
		if (SceneManager.GetActiveScene().name == "Menu 2")
		{
			aud.volume += fadeRate * Time.deltaTime * 8;
			if (aud.volume > 0.9)
			{
				aud.volume = 0.9f;
			}
		}
		if (SceneManager.GetActiveScene().name == "Game 2")
		{
			aud.volume -= fadeRate * Time.deltaTime * 5;
			if (aud.volume < 0.1)
			{
				aud.volume = 0.1f;
			}
		}
		if (SceneManager.GetActiveScene().name == "Menu 3")
		{
			aud.volume += fadeRate * Time.deltaTime * 8;
			if (aud.volume > 0.9)
			{
				aud.volume = 0.9f;
			}
		}
		if (SceneManager.GetActiveScene().name == "Game 3")
		{
			aud.volume -= fadeRate * Time.deltaTime * 5;
			if (aud.volume < 0.1)
			{
				aud.volume = 0.1f;
			}
		}
		if (SceneManager.GetActiveScene().name == "Menu 4")
		{
			aud.volume += fadeRate * Time.deltaTime * 8;
			if (aud.volume > 0.9)
			{
				aud.volume = 0.9f;
			}
		}
		if (SceneManager.GetActiveScene().name == "Game 4")
		{
			aud.volume -= fadeRate * Time.deltaTime * 5;
			if (aud.volume < 0.1)
			{
				aud.volume = 0.1f;
			}
		}
	}

//	IEnumerator ExecuteAfterTime (float time)
//	{
//		yield return new WaitForSeconds (time);
//		animator.SetBool ("up",true);
//		animator.SetBool ("down",false);
//	}

//	public void WallpaperChange(int a)
//	{
//		if (a == 1)
//		{
//			rend = orange;
//		}
//		if (a == 2)
//		{
//			rend = blue;
//		}
//		if (a == 3)
//		{
//			rend = lightblue;
//		}
//		if (a == 4)
//		{
//			rend = darkblue;
//		}
//		if (a == 5)
//		{
//			rend = pink;
//		}
//	}
}

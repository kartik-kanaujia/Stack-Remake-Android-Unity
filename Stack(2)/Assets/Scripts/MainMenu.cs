using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

	public Text scoreText;
//	private Animator animator;

	private void Start()
	{
		scoreText.text = PlayerPrefs.GetInt ("score").ToString();
//		animator = GetComponent<Animator> ();
	}

	public void ToGame(string level)
	{
		SceneManager.LoadScene (level);
	}

	public void ToMenu(string level)
	{
		SceneManager.LoadScene (level);
	}

	public void Quit()
	{
		Application.Quit();
	}

	private void Update()
	{
		if (SceneManager.GetActiveScene().name == "Menu")
		{
//			animator.SetBool ("up",false);

			if (Input.GetKeyDown(KeyCode.Escape)) {Application.Quit();}
		}
		if (SceneManager.GetActiveScene().name == "Game")
		{
//			animator.SetBool ("up",true);

			if (Input.GetKeyDown(KeyCode.Escape)) {SceneManager.LoadScene("Menu");}
		}
		if (SceneManager.GetActiveScene().name == "Menu 1")
		{
//			animator.SetBool ("up",false);

			if (Input.GetKeyDown(KeyCode.Escape)) {Application.Quit();}
		}
		if (SceneManager.GetActiveScene().name == "Game 1")
		{
//			animator.SetBool ("up",true);

			if (Input.GetKeyDown(KeyCode.Escape)) {SceneManager.LoadScene("Menu 1");}
		}
		if (SceneManager.GetActiveScene().name == "Menu 2")
		{
//			animator.SetBool ("up",false);

			if (Input.GetKeyDown(KeyCode.Escape)) {Application.Quit();}
		}
		if (SceneManager.GetActiveScene().name == "Game 2")
		{
//			animator.SetBool ("up",true);

			if (Input.GetKeyDown(KeyCode.Escape)) {SceneManager.LoadScene("Menu 2");}
		}
		if (SceneManager.GetActiveScene().name == "Menu 3")
		{
//			animator.SetBool ("up",false);

			if (Input.GetKeyDown(KeyCode.Escape)) {Application.Quit();}
		}
		if (SceneManager.GetActiveScene().name == "Game 3")
		{
//			animator.SetBool ("up",true);

			if (Input.GetKeyDown(KeyCode.Escape)) {SceneManager.LoadScene("Menu 3");}
		}
		if (SceneManager.GetActiveScene().name == "Menu 4")
		{
//			animator.SetBool ("up",false);

			if (Input.GetKeyDown(KeyCode.Escape)) {Application.Quit();}
		}
		if (SceneManager.GetActiveScene().name == "Game 4")
		{
//			animator.SetBool ("up",true);

			if (Input.GetKeyDown(KeyCode.Escape)) {SceneManager.LoadScene("Menu 4");}
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wait : MonoBehaviour {

	void Awake()
	{
		StartCoroutine (ExecuteAfterTime (2f));

	}

	IEnumerator ExecuteAfterTime (float time)
	{
		yield return new WaitForSeconds (time);
		SceneManager.LoadScene ("Menu");

	}
}

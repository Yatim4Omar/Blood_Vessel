﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour {

	public void play(){
		SceneManager.LoadScene ("game");
	}

	public void quit (){
		Application.Quit ();
	}
}

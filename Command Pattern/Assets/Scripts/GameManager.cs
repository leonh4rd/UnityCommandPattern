using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameObject pauseMenu;
	private static bool pause;

	void Start () {
		pause = false;
		pauseMenu = GameObject.Find("PausePanel");
		pauseMenu.SetActive(false);
	}

	public static bool Pause
	{	
		get{ return pause; }
		set{ pause = value; }
	}

	public static GameObject PauseMenu
	{
		get{ return pauseMenu; }		
	}	
}

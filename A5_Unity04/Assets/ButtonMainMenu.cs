using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMainMenu : MonoBehaviour 
{

	public GameObject UIControllerCanvas;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void ClickMainBtn()
	{
		Debug.Log ("MAIN_BTN_CLICKED");
		UIControllerCanvas.SendMessage ("SwitchToMenu", "MainMenu");
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ControllerMain : MonoBehaviour 
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

	public void OnClickBtnPlay()
	{
		Debug.Log ("MAIN_MENU_BTN_CLICKED: Play");
		UIControllerCanvas.SendMessage ("SwitchToMenu", "HUD");
	}

	public void OnClickBtnOption()
	{
		Debug.Log ("MAIN_MENU_BTN_CLICKED: Option");
		UIControllerCanvas.SendMessage ("SwitchToMenu", "OptionMenu");
	}

	public void OnClickBtnExit()
	{
		Debug.Log ("MAIN_MENU_BTN_CLICKED: Exit");
        UIControllerCanvas.SendMessage ("SwitchToMenu", "ExitGame");
	}

	public void ChangePlayerName(string nameNew)
	{
		UIControllerCanvas.SendMessage("SetPlayerName", nameNew);
	}
}

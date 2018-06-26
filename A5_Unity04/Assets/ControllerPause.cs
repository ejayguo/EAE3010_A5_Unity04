using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPause : MonoBehaviour 
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

    public void OnClickBtnResume()
    {
        Debug.Log ("MAIN_MENU_BTN_CLICKED: Resume");
        UIControllerCanvas.SendMessage ("SwitchToMenu", "HUD");
    }

	public void OnClickBtnOption()
	{
		Debug.Log ("MAIN_MENU_BTN_CLICKED: Option");
		UIControllerCanvas.SendMessage ("SwitchToMenu", "OptionMenu");
	}

	public void OnClickBtnBackToMain()
	{
		Debug.Log ("MAIN_MENU_BTN_CLICKED: BackToMain");
		UIControllerCanvas.SendMessage ("SwitchToMenu", "MainMenu");
	}
}

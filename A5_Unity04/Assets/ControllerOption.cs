using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerOption : MonoBehaviour 
{
	public GameObject UIControllerCanvas;
    public string menuGo = "MainMenu";

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void OnClickBtnBackToPause()
	{
		Debug.Log ("MAIN_MENU_BTN_CLICKED: BackToPause");
		UIControllerCanvas.SendMessage ("SwitchToMenu", "PauseMenu");
	}

	public void OnClickBtnBackToMain()
	{
		Debug.Log ("MAIN_MENU_BTN_CLICKED: BackToMain");
		UIControllerCanvas.SendMessage ("SwitchToMenu", "MainMenu");
	}

    public void SetDisplayPlayerName(bool isOn)
    {
        UIControllerCanvas.SendMessage("SetDisplayPlayerName", isOn);
    }

    public void SetHUDTransparency(float alpha)
    {
        UIControllerCanvas.SendMessage("SetHUDTransparency", alpha);
    }

    public void SetGoDirection(string menuNew)
    {
        menuGo = menuNew;
    }

    public void GoDirection()
    {
        UIControllerCanvas.SendMessage ("SwitchToMenu", menuGo);
    }

}

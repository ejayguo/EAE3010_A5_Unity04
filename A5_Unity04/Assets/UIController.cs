using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour 
{
	public string namePlayer = "";
    public float hudTransparency = 1.0f;
    public bool displayPlayerName = true;

	public GameObject hud;
	public GameObject menuMain;
	public GameObject menuPause;
	public GameObject menuOption;



	// Use this for initialization
	void Start () 
	{
        SwitchToMenu ("MainMenu");
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void SwitchToMenu(string menuName)
	{
        if (menuName == "MainMenu")
        {
            Debug.Log("Switch to MainMenu");
            menuMain.SetActive(true);
            menuPause.SetActive(false);
            menuOption.SetActive(false);
            hud.SetActive(false);
        }
        else if (menuName == "PauseMenu")
        {
            Debug.Log("Switch to Pause Menu");
            menuMain.SetActive(false);
            menuPause.SetActive(true);
            menuOption.SetActive(false);
            hud.SetActive(false);
        }
        else if (menuName == "OptionMenu")
        {
            Debug.Log("Switch to Option Menu");
            menuMain.SetActive(false);
            menuPause.SetActive(false);
            menuOption.SetActive(true);
            hud.SetActive(false);
        }
        else if (menuName == "HUD")
        {
            Debug.Log("Switch to HUD");
            menuMain.SetActive(false);
            menuPause.SetActive(false);
            menuOption.SetActive(false);
            hud.SetActive(true);
            hud.SendMessage("SetPlayerName", namePlayer);
            hud.SendMessage("SetTransparency", hudTransparency);
            hud.SendMessage("DisplayPlayerName", displayPlayerName);
        }
        else if (menuName == "ExitGame")
        {
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }
	}

	public void SetPlayerName(string nameNew)
	{
		namePlayer = nameNew;
		Debug.Log(namePlayer);
	}

    public void SetDisplayPlayerName(bool isOn)
    {
        displayPlayerName = isOn;
        Debug.Log("DipslayPlayerName: " + displayPlayerName);
    }

    public void SetHUDTransparency(float alpha)
    {
        
        hudTransparency = alpha;
        Debug.Log("HUDTrans: " + hudTransparency);
    }
}

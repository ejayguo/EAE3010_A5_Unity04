using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerHUD : MonoBehaviour 
{
    public GameObject UIControllerCanvas;
    public string namePlayer;
    public Text hud;
    public Text player;
    public Text readme;
    public Color colorHUD;
    public Color colorPlayer;
    public Color colorReadme;

	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("ESC_PRESSED: Pause");
            UIControllerCanvas.SendMessage ("SwitchToMenu", "PauseMenu");
        }
            
		
	}

    public void SetPlayerName(string name)
    {
        namePlayer = name;
        player.text = namePlayer + " is playing.";
    }

    public void DisplayPlayerName(bool display)
    {
        Debug.Log("HUD: " + display);
        if (!display)
        {
            player.color = new Color(colorPlayer.r, colorPlayer.g, colorPlayer.b, 0.0f);
        }
        else
        {
            player.color = new Color(colorPlayer.r, colorPlayer.g, colorPlayer.b, hud.color.a);
        }
    }

    public void SetTransparency(float alpha)
    {

        hud.color = new Color(colorHUD.r, colorHUD.g, colorHUD.b, alpha);
        readme.color = new Color(colorReadme.r, colorReadme.g, colorReadme.b, alpha);

        if (player.color.a > 0.0000001f)
        {
            player.color = new Color(colorPlayer.r, colorPlayer.g, colorPlayer.b, alpha);
        }
    }
}

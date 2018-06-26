using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionDirection : MonoBehaviour 
{
    public GameObject controllerOption;
    public Dropdown dropDown;
	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

    public void OnDirectionChanged(int dir)
    {
        Debug.Log("DropDown Value: " + dropDown.value);
        if (dropDown.value == 0)
        {
            controllerOption.SendMessage("SetGoDirection", "MainMenu");
        }
        else if (dropDown.value == 1)
        {
            controllerOption.SendMessage("SetGoDirection", "PauseMenu");
        }
        else if (dropDown.value == 2)
        {
            controllerOption.SendMessage("SetGoDirection", "HUD");
        }
    }

    public void OnGoClicked()
    {
        controllerOption.SendMessage("GoDirection");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputName : MonoBehaviour 
{
    public GameObject menuMain;
    public InputField mainInputField;

    // Checks if there is anything entered into the input field.
    void LockInput(InputField input)
    {
        menuMain.SendMessage("ChangePlayerName", input.text);
    }

    public void Start()
    {
        //Adds a listener that invokes the "LockInput" method when the player finishes editing the main input field.
        //Passes the main input field into the method when "LockInput" is invoked
        mainInputField.onValueChanged.AddListener(delegate {LockInput(mainInputField); });
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; //to listen to action

public class GameMenuManager : MonoBehaviour
{
    //------------------//
    //--- Parameters ---//
    //------------------//

    // Game Menu Canvas:
    [SerializeField] private GameObject menu;
    // Input action to trigger event:
    [SerializeField] private InputActionProperty showButton;



    // Update is called once per frame
    void Update()
    {
        if (showButton.action.WasPressedThisFrame())
        {
            // Make menu canvas appear:
            menu.SetActive(!menu.activeSelf);
        }
    }
}

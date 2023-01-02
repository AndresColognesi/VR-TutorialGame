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
    // Reference to player head:
    [SerializeField] private Transform head;
    // Offset distance from menu to head:
    [SerializeField] float spawnDistance = 2;



    // Update is called once per frame
    void Update()
    {
        if (showButton.action.WasPressedThisFrame())
        {
            // Make menu canvas appear:
            menu.SetActive(!menu.activeSelf);
            // Translate the menu to the front of the player view:
            menu.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;
        }
        // Make canvas perpendicular to player view and follow player head movement:
        menu.transform.LookAt(new Vector3(head.position.x, menu.transform.position.y, head.position.z));
        // Flip canvas:
        menu.transform.forward *= -1;
    }
}

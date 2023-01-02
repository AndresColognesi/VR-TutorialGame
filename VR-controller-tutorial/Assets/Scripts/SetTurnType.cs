using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SetTurnType : MonoBehaviour
{
    //------------------//
    //--- Parameters ---//
    //------------------//

    // Turning type providers:
    [SerializeField] private ActionBasedContinuousTurnProvider continuousTurn;
    [SerializeField] private ActionBasedSnapTurnProvider snapTurn;



    //---------------//
    //--- Methods ---//
    //---------------//

    public void SetTypeFromIndex(int index)
    {
        /***
         * Based on the UI Dropdown index, sets the desired turn provider
         * to continuous or snap rotation.
        ***/

        if (index == 0) //continuous movement
        {
            snapTurn.enabled = false;
            continuousTurn.enabled = true;
        }
        else if (index == 1) //snapping moviment
        {
            continuousTurn.enabled = false;
            snapTurn.enabled = true;
        }
    }
}

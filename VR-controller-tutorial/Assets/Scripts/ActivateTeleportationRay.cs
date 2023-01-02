using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateTeleportationRay : MonoBehaviour
{
    //-----------------------//
    //--- Class Attributes --//
    //-----------------------//


    [SerializeField] private GameObject teleportationRay;
    [SerializeField] private InputActionProperty activationInput;


    // Update is called once per frame
    void Update()
    {
        //Set teleportation ray to active while holding trigger button:
        teleportationRay.SetActive(activationInput.action.ReadValue<float>() > 0.1f);
    }
}

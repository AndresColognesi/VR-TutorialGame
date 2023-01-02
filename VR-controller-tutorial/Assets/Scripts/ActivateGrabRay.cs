using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivateGrabRay : MonoBehaviour
{
    //------------------//
    //--- Parameters ---//
    //------------------//

    // Ray interactors:
    [SerializeField] private GameObject rightGrabRay;
    // Direct Interactors:
    [SerializeField] private XRDirectInteractor rightGrabDirect;



    // Update is called once per frame
    void Update()
    {
        // Only display the grab ray when there is no object being grabbed:
        rightGrabRay.SetActive(rightGrabDirect.interactablesSelected.Count == 0);
    }
}

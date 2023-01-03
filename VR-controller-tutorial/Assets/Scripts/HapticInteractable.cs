using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HapticInteractable : MonoBehaviour
{
    //------------------//
    //--- Parameters ---//
    //------------------//

    // Haptic feedback parameters:
    [Range(0,1)] //set 0 to 1 slider for variable below
    [SerializeField] private float intensity;
    [SerializeField] private float duration;



    //-------------//
    //--- Start ---//
    //-------------//

    // Start is called before the first frame update
    void Start()
    {
        // Get current object interactable:
        XRBaseInteractable interactable = GetComponent<XRBaseInteractable>();
        // Add custom method as listener when an Activation event occurs:
        interactable.activated.AddListener(TriggerHaptic);
    }



    //---------------//
    //--- Methods ---//
    //---------------//

    public void TriggerHaptic(BaseInteractionEventArgs eventArgs)
    {
        /***
         * Listener function that gets the event and calls the haptic feedback
         * function if the given event object is an XRBaseController.
         ***/

        if(eventArgs.interactorObject is XRBaseControllerInteractor controllerInteractor)
        {
            // Call the haptic feedback function:
            TriggerHaptic(controllerInteractor.xrController);
        }
    }

    public void TriggerHaptic(XRBaseController controller)
    {
        /***
         * Get an XRBaseController object and send haptic feedback to it.
         ***/

        // When a feedback should be send:
        if (intensity > 0)
        {
            // Send haptic feedback
            controller.SendHapticImpulse(intensity, duration);
        }
    }
}

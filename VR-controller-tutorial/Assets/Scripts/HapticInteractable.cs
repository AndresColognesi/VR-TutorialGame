using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

//--------------------//
//--- Custom Class ---//
//--------------------//

[System.Serializable] //to display on the Unity Editor
public class Haptic
{
    //------------------//
    //--- Parameters ---//
    //------------------//

    // Haptic feedback parameters:
    [Range(0, 1)] //set 0 to 1 slider for variable below
    [SerializeField] private float intensity;
    [SerializeField] private float duration;


    //---------------//
    //--- Methods ---//
    //---------------//

    public void TriggerHaptic(BaseInteractionEventArgs eventArgs)
    {
        /***
         * Listener function that gets the event and calls the haptic feedback
         * function if the given event object is an XRBaseController.
         ***/

        if (eventArgs.interactorObject is XRBaseControllerInteractor controllerInteractor)
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



//-------------------------------//
//--- Main Monobehavior Class ---//
//-------------------------------//
public class HapticInteractable : MonoBehaviour
{
    //------------------//
    //--- Parameters ---//
    //------------------//

    [SerializeField] private Haptic hapticOnActivated;
    [SerializeField] private Haptic hapticHoverEntered;
    [SerializeField] private Haptic hapticHoverExited;
    [SerializeField] private Haptic hapticSelectEntered;
    [SerializeField] private Haptic hapticSelectExited;


    // Start is called before the first frame update
    void Start()
    {
        // Get current object interactable:
        XRBaseInteractable interactable = GetComponent<XRBaseInteractable>();

        // Add custom method as listener when an Activation event occurs:
        interactable.activated.AddListener(hapticOnActivated.TriggerHaptic);
        // Add custom method as listener when an Hover Enter event occurs:
        interactable.activated.AddListener(hapticHoverEntered.TriggerHaptic);
        // Add custom method as listener when an Hover Exit event occurs:
        interactable.activated.AddListener(hapticHoverExited.TriggerHaptic);
        // Add custom method as listener when an Select Enter event occurs:
        interactable.activated.AddListener(hapticSelectEntered.TriggerHaptic);
        // Add custom method as listener when an Select Exit event occurs:
        interactable.activated.AddListener(hapticSelectExited.TriggerHaptic);
    }
}

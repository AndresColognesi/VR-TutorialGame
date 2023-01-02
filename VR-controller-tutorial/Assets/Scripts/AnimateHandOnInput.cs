using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    // Class fields //

    [SerializeField] InputActionProperty pinchAnimationAction;
    [SerializeField] InputActionProperty gripAnimationAction;

    private Animator handAnimator;
    private float triggerValue;
    private float gripValue;

    // Start is called before the first frame update
    void Start()
    {
        // Get animator of current game object:
        handAnimator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get pinch (trigger) button value:
        triggerValue = pinchAnimationAction.action.ReadValue<float>();
        // Run pinch animation:
        handAnimator.SetFloat("Trigger", triggerValue);

        // Get grip button value:
        gripValue = gripAnimationAction.action.ReadValue<float>();
        // Run pinch animation:
        handAnimator.SetFloat("Grip", gripValue);
    }
}

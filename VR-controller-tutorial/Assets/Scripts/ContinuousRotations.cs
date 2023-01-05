using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinuousRotations : MonoBehaviour
{
    //------------------//
    //--- Parameters ---//
    //------------------//

    // To store transform of current object:
    private Transform my_transform;
    // Rotation velocity parameters in degrees per second:
    [SerializeField] private float w_x = 20f;
    [SerializeField] private float w_y = 50f;
    [SerializeField] private float w_z = 30f;


    //---------------//
    //--- Methods ---//
    //---------------//

    private void Rotations(Transform transf)
    {
        /***
         * Applies continuous y and z rotation to the object.
         ***/
        // Get frame rate for normalization:
        float dt = Time.deltaTime;
        // Rotate in local axis using Euler angles in degrees/second:
        transf.Rotate(w_x * dt, w_y * dt, w_z * dt, Space.Self);
    }



    //------------------------//
    //--- Built-in Methods ---//
    //------------------------//

    // Start is called before the first frame update
    void Start()
    {
        // Get current object transform:
        my_transform = gameObject.transform;
    }

    // Using Fixed update because we are using the Unity Physics system!
    void FixedUpdate()
    {
        // Apply rotation each frame:
        Rotations(my_transform);
    }
}

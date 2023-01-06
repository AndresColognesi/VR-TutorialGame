using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetProperties : MonoBehaviour
{
    //------------//
    // Properties //
    //------------//

    // Dropdown with Target types:
    private enum TargetType { L, M, S };
    [SerializeField] TargetType targetType;
    
    // Class attributes:
    private int target_score;



    //---------------//
    //--- Methods ---//
    //---------------//

    public int getTargetScore()
    {
        /***
         * Retrieve the value of the current target
         ***/

        return target_score;
    }

    //------------------------//
    //--- Built-in Methods ---//
    //------------------------//

    // Start is called before the first frame update
    void Start()
    {
        // Set the score based on the type:
        switch (targetType)
        {
            case TargetType.L:
                target_score = 10;
                break;
            case TargetType.M:
                target_score = 30;
                break;
            case TargetType.S:
                target_score = 100;
                break;
        }
    }
}

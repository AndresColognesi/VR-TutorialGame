using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetProperties : MonoBehaviour
{
    //------------//
    // Properties //
    //------------//

    // Access the Game Manager score counter class:
    [SerializeField] private ScoreCounter scoreCounter;

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


    private void OnCollisionEnter(Collision collision)
    {
        /***
         * When hit by a bullet, removes the target object from scene 
         * and sends the score to the Game Manager.
         ***/

        if (collision.collider.tag == "Bullet")
        {
            // Add target score to total level score:
            scoreCounter.AddScore(target_score);
            // Display total score:
            Debug.Log("Scored " + target_score.ToString() + " points!");
            Debug.Log("Total Points: " + scoreCounter.GetTotalScore().ToString());
        }

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

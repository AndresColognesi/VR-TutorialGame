using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    //------------//
    // Properties //
    //------------//

    // Total score for the given level:
    private static int total_score = 0;


    //---------------//
    //--- Methods ---//
    //---------------//

    // Public Methods:
    public void AddScore(int score)
    {
        /***
         * Add the given score to the total score of the level.
         ***/

        total_score += score;
    }

    public int GetTotalScore()
    {
        /***
         * Retrieves the total score value
         ***/

        return total_score;
    }

    public void ClearTotalScore()
    {
        /***
         * Resets the total score value.
         ***/

        total_score = 0;
    }
}

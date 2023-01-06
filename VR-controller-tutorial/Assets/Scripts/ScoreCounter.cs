using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    //------------//
    // Properties //
    //------------//

    // Current total score for the given level:
    private static int total_score = 0;
    // Desired score to complete the level:
    private int finish_level_score;

    // To store load next scene script of the Game Manager:
    private LoadNextScene loadNextScene;


    //------------------------//
    //--- Built-in Methods ---//
    //------------------------//

    // Start is called before the first frame update
    void Start()
    {
        // Set the finishing level score for the current scene:
        finish_level_score = SceneManager.GetActiveScene().buildIndex * 10;

        // Get the LoadNextLevel component of this game object:
        loadNextScene = gameObject.GetComponent<LoadNextScene>();
    }



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

    public void CheckLevelFinished()
    {
        /***
         * Based on the scene index, checks if score has reached
         * the desired value for the level and changes to next scene/level.
         ***/

        if (total_score == finish_level_score) //meaning the level is complete
        {
            // Reset the total score:
            ClearTotalScore();
            // Change to next level:
            loadNextScene.LoadNext();
        }
    }
}

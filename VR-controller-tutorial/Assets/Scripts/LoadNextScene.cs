using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{
    //------------------//
    // Custom Functions //
    //------------------//

    public void LoadNext()
    {
        // Load the next scene based on the build index number:
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{
    //------------------//
    // Custom Functions //
    //------------------//

    public void LoadNext()
    {
        Debug.Log("The function is being triggered and the current buid index is" + SceneManager.GetActiveScene().buildIndex.ToString());
        // Load the next scene based on the build index number:
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
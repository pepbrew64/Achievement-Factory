using UnityEngine;

public class QuitManager : MonoBehaviour
{
    //This quits the game
    public void QuitGame()
    {
        //This closes the application
        Application.Quit();

        //This creates a message to verify that it works correctly
        Debug.Log("Closing the application...");
    }

}

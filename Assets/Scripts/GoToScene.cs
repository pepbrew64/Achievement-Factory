using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{
    //This loads a new scene by the build index parameter
    public void SceneChangeByIndex(int index)
    {
        SceneManager.LoadScene(index);
    }
    //This loads a new scene by the name of the scene
    public void SceneChangeByName(string name)
    {
        SceneManager.LoadScene(name);
    }

}


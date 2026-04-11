using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void OpenScene(string sceneName)
    {
        Scene currentScene = SceneManager.GetActiveScene();

        if (currentScene.name == sceneName)
        {
            return;
        }
        else
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
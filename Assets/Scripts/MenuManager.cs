using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    Scene currentScene;
    public void StartButton()
    {
        SceneManager.GetSceneByBuildIndex(currentScene.buildIndex+1);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}

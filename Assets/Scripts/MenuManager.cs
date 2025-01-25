using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    Scene currentScene;
    public void StartButton()
    {
        if (DataManager.Instance.Debug) Debug.Log("Start Button");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitButton()
    {
        if (DataManager.Instance.Debug) Debug.Log("Quit Button");
        Application.Quit();
    }
}

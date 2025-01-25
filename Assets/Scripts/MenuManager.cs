using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    Scene currentScene;


    public void StartButton()
    {
        if (DataManager.Instance.DebugMode) Debug.Log("Start Button");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitButton()
    {
        if (DataManager.Instance.DebugMode) Debug.Log("Quit Button");
        Application.Quit();
    }

    public void OptionsButton()
    {
        if (DataManager.Instance.DebugMode) Debug.Log("Options Button (Nothing atm)");

    }

    public void QuitToMainMenuButton()
    {
        if (DataManager.Instance.DebugMode) Debug.Log("QuitToMainMenu Button");
        SceneManager.LoadScene("Start");
    }
}

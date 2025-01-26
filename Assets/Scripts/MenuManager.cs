using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject optionsPrefab;
    GameObject optionsManager;

    Scene currentScene;
    
    void OnEnable() {
        OptionsManager[] optionsManagers = FindObjectsByType<OptionsManager>(FindObjectsSortMode.None);

        if (optionsManagers.Length > 0)
        {
            optionsManager = optionsManagers[0].gameObject;
            optionsManager.SetActive(false);
        }
    }

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
        if (DataManager.Instance.DebugMode) Debug.Log("Options Button");

        if (optionsManager == null)
            optionsManager = Instantiate(optionsPrefab, Vector3.zero, Quaternion.identity);
        else
            optionsManager.SetActive(true);
    }

    public void QuitToMainMenuButton()
    {
        if (DataManager.Instance.DebugMode) Debug.Log("QuitToMainMenu Button");
        SceneManager.LoadScene("Start");
    }
}

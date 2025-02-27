using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Analytics;

public class GameManager : MonoBehaviour
{
    public bool isBlowPressed;
    public bool isPaused;
    private bool isWin = false;
    [SerializeField] GameObject pauseMenuObject;
    MenuManager menuManager;
    
    void Start()
    {
        menuManager = GetComponent<MenuManager>();
    }

    void Update()
    {
        if (!isWin) {
            if (Input.GetKey(KeyCode.Space) && !isPaused)
            {
                if (DataManager.Instance.DebugMode) Debug.Log("Input: Space Key");
                isBlowPressed = true;
            }
            else
            {
                isBlowPressed = false;
            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (DataManager.Instance.DebugMode) Debug.Log("Input: Escape Key");

                if (isPaused)
                {
                    pauseMenuObject.SetActive(false);
                    isPaused = false;
                }
                else
                {
                    pauseMenuObject.SetActive(true);
                    isPaused = true;
                }
                
            }
        }
    }
    public void setWin(bool win) {
        isWin = win;
    }
}

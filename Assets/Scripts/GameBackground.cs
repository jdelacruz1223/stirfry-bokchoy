using UnityEngine;

public class GameBackground : MonoBehaviour
{
    GameObject currentBackground;
    [SerializeField] GameObject[] backgrounds;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(name);
        }
    }

    void ChangeBackground()
    {
        // e
    }
}

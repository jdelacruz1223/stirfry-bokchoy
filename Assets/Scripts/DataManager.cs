using UnityEngine;
using UnityEngine.Rendering;

public class DataManager : MonoBehaviour
{
    int currentBackgroundNumber = -1;
    Transform backgroundParent;

    private static DataManager instance;
    public static DataManager Instance {get {return instance;}}

    public int currentState;
    
    [SerializeField] AudioSource audioSource;
    [SerializeField] public bool DebugMode;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start() {
        GoNextBackground();
    }

    void Update() {
        Debug.Log(audioSource.volume);

        if (Input.GetKeyDown(KeyCode.Tab))
            GoNextBackground();
    }

    public void GoNextBackground()
    {
        currentBackgroundNumber++;

        if (backgroundParent == null)
            backgroundParent = GameObject.FindGameObjectWithTag("Background Parent").transform;
        
        if (currentBackgroundNumber >= backgroundParent.childCount)
            currentBackgroundNumber -= backgroundParent.childCount;
        
        for (int i = 0; i < backgroundParent.childCount; i++)
            backgroundParent.GetChild(i).gameObject.SetActive(i == currentBackgroundNumber);
    }

    public float GetVolume()
    {
        return audioSource.volume;
    }

    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }
}

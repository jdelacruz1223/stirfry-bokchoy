using UnityEngine.UI;
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
    [SerializeField] private Sprite border1;
    [SerializeField] private Sprite border2;
    private Image gameborder;
    private int rand;

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
        rand =  Random.Range(0,100) % 2;
    }

    void Update() {
        Debug.Log(audioSource.volume);
        if (gameborder == null) gameborder = GameObject.FindGameObjectWithTag("Border").GetComponent<Image>();
        if (rand == 1) {
            gameborder.sprite = border1;
        } else {
            gameborder.sprite = border2;
        }
        if (Input.GetKeyDown(KeyCode.Tab))
            GoNextBackground();
    }

    public void GoNextBackground()
    {
        // look for the game object that has all the backgrounds childed to it. if it can't be found, then we can't move forward
        // with this function
        GameObject[] backgroundParents = GameObject.FindGameObjectsWithTag("Background Parent");
        if (backgroundParents.Length == 0)
            return;
        
        backgroundParent = backgroundParents[0].transform;
        
        // go to the next background. if we're currently at the last one, then we simply loop back to the first one
        currentBackgroundNumber++;
        if (currentBackgroundNumber >= backgroundParent.childCount)
            currentBackgroundNumber -= backgroundParent.childCount;
        
        // lastly, we simply activate the currently-selected background, and deactivate the other ones
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

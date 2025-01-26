using UnityEngine;
using UnityEngine.Rendering;

public class DataManager : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;

    public CheckpointPin currentCheckpoint;

    private static DataManager instance;
    public static DataManager Instance {get {return instance;}}
    
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

    public void SetCheckpoint(CheckpointPin newCheckpoint)
    {
        currentCheckpoint = newCheckpoint;
    }

    void Update() {
        Debug.Log(audioSource.volume);
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

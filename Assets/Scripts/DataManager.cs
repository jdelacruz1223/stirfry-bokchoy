using UnityEngine;

public class DataManager : MonoBehaviour
{
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
}

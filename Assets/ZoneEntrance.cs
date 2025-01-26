using UnityEngine;

public class ZoneEntrance : MonoBehaviour
{
    [SerializeField] CheckpointPin checkpointToResetTo;
    DataManager dataManager;

    void Start()
    {
        dataManager = FindAnyObjectByType<DataManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (checkpointToResetTo != null)
        {
            //dataManager.SetCheckpoint(checkpointToResetTo);
        }
    }
}

using UnityEngine;

public class CheckpointActivator : MonoBehaviour
{
    [SerializeField] CheckpointPin checkpoint;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
            checkpoint.ActivateCheckpoint();
    }
}

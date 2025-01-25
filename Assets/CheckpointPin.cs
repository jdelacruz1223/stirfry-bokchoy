using UnityEngine;

public class CheckpointPin : MonoBehaviour
{
    [SerializeField] BoxCollider pinFloor;
    Transform player;
    
    void Update()
    {
        // we enable the pin floor only if the player is above the pin, thereby allowing the player to fall onto the checkpoint
        Vector3 toPlayer = player.position - transform.position;
        pinFloor.enabled = toPlayer.y > 0;
    }
}

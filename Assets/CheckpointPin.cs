using UnityEngine;

public class CheckpointPin : MonoBehaviour
{
    [SerializeField] BoxCollider2D pinFloor1;
    [SerializeField] BoxCollider2D pinFloor2;

    Transform player;
    
    void Update()
    {
        // we enable the pin floor only if the player is above the pin, thereby allowing the player to fall onto the checkpoint
        Vector3 toPlayer = player.position - transform.position;
        EnableFloor(toPlayer.y > 0);
    }

    void EnableFloor(bool a)
    {
        pinFloor1.enabled = a;
        pinFloor2.enabled = a;
    }
}

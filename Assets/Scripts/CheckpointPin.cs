using UnityEngine;

public class CheckpointPin : MonoBehaviour
{
    [SerializeField] BoxCollider2D pinFloor1;
    [SerializeField] BoxCollider2D pinFloor2;

    DataManager dataManager;
    Transform player;

    void Start()
    {
        dataManager = FindAnyObjectByType<DataManager>();
    }
    
    void Update()
    {
        EnableFloor();
    }

    // we enable the pin floor only if the player is above said floor, thereby allowing the player to fall onto the checkpoint
    void EnableFloor()
    {
        // the colliders are turned 45 degrees, so we simply add the x difference to the pin's y position to check if the player
        // is above the FLOOR and not the pin itself
        float xDifference = Mathf.Abs(transform.position.x - player.position.x);
        float yToCompare = transform.position.y + xDifference;

        bool isPlayerAbovePinFloor = player.position.y > yToCompare;

        pinFloor1.enabled = isPlayerAbovePinFloor;
        pinFloor2.enabled = isPlayerAbovePinFloor;
    }

    public void ActivateCheckpoint()
    {
        //dataManager.SetCheckpoint(this);
    }
}

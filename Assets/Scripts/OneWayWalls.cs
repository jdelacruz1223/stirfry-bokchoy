using UnityEngine;

public class OneWayWalls : MonoBehaviour
{
    [SerializeField] BoxCollider2D wallCollider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collider) {
        if (wallCollider != null) wallCollider.enabled = false;
    }
    void OnTriggerExit2D(Collider2D collider) {
        if (wallCollider != null) wallCollider.enabled = true;
    }

}

using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class HazardScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collider) {
        if (collider.CompareTag("Player")) {
            
        }
    }
}

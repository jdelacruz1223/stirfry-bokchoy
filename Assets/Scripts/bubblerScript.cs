using Unity.VisualScripting;
#if UNITY_EDITOR
    using UnityEditor.Experimental.GraphView;
    #endif
using UnityEngine;

public class bubblerScript : MonoBehaviour
{
    [SerializeField] private float force = 5f;
    public bool isPull = false;
    private Rigidbody2D ringRB;
    private Vector2 dir;
    private ParticleSystem particle;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        particle = GetComponentInChildren<ParticleSystem>();
        if(isPull) {
            dir = -transform.up;
        } else {
            dir = transform.up;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) {
            Debug.Log("push");
            if (ringRB != null) ringRB.AddForce(dir * force);
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            particle.Play();
        } else if (Input.GetKeyUp(KeyCode.Space)) {
            particle.Stop(true, ParticleSystemStopBehavior.StopEmitting);
        }
    }
    private void OnTriggerEnter2D(Collider2D collider) {
        Debug.Log("enter");
        if (collider != null) ringRB = collider.gameObject.GetComponent<Rigidbody2D>();
    }
    private void OnTriggerExit2D(Collider2D collider) {
        ringRB = null;
    }
} 


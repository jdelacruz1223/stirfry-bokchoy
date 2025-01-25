using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
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
        particle = GetComponent<ParticleSystem>();
        if(isPull) {
            dir = -transform.up;
        } else {
            dir = transform.up;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && ringRB != null) {
            Debug.Log("push");
            ringRB.AddForce(dir * force);
            particle.Play();
        } else {
            particle.Pause();
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


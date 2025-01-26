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
    private GameManager gameManager;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        particle = GetComponentInChildren<ParticleSystem>();
        if(isPull) {
            dir = -transform.up;
            particle.transform.localPosition = new Vector2(particle.transform.localPosition.x, particle.transform.localPosition.y + 8f);
            particle.transform.localRotation = new Quaternion(particle.transform.localRotation.x * -1, particle.transform.localRotation.y, particle.transform.localRotation.z, particle.transform.localRotation.w);
        } else {
            dir = transform.up;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.isBlowPressed) {
            Debug.Log("push");
            if (ringRB != null)
            {
                ringRB.AddForce(dir * force);
                ringRB.GetComponent<RingRotator>().RotateRing(dir);
            } 
        }
        if (!gameManager.isPaused && Input.GetKeyDown(KeyCode.Space)) {
            particle.Play();
        } else if (!gameManager.isPaused && Input.GetKeyUp(KeyCode.Space)) {
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


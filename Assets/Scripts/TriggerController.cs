using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerController : MonoBehaviour
{
    [SerializeField] private GameObject endScreen;
    [SerializeField] private AudioSource fanfare;
    private GameManager gameManager;
    void Start() {
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
    }
    private IEnumerator endSequence() {
        gameManager.setWin(true);
        if(endScreen != null) endScreen.SetActive(true);
        if (fanfare != null && fanfare.clip != null) fanfare.Play();
        yield return new WaitForSeconds(5f);
        gameManager.setWin(false);
        SceneManager.LoadScene("End");
    }
    void OnTriggerEnter2D(Collider2D trigger)
    {
        Debug.Log("end");
        StartCoroutine("endSequence");
    }
}

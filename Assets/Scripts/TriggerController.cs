using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D trigger)
    {
        Debug.Log("end");
        SceneManager.LoadScene("End");
    }
}

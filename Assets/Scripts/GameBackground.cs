using UnityEngine;

public class GameBackground : MonoBehaviour
{
    [SerializeField] GameObject[] backgrounds;

    public void ChangeBackground(string name)
    {
        foreach (GameObject background in backgrounds)
        {
            background.SetActive(name == background.name);
        }
    }
}

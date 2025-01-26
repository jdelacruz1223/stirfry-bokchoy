using UnityEngine;
using UnityEngine.UI;

public class OptionsManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;

    GameObject menuManager;
    DataManager dataManager;

    void OnEnable() {
        menuManager = FindAnyObjectByType<MenuManager>().gameObject;
        dataManager = FindAnyObjectByType<DataManager>();

        menuManager.SetActive(false);
        volumeSlider.value = dataManager.GetVolume();
    }

    void Update()
    {
        dataManager.SetVolume(volumeSlider.value);
    }

    public void GoBack()
    {
        menuManager.SetActive(true);
    }
}

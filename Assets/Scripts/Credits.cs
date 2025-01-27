using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{
    [SerializeField] int fadeSpeed = 1;
    [SerializeField] int scrollSpeed = 100;
    [SerializeField] int nameSeparation = 400;
    [SerializeField] float topOffset = -400;
    [SerializeField] float bottomOffset = 400;
    [SerializeField] RectTransform nameList;
    [SerializeField] UnityEngine.UI.Image oceanPic;
    [SerializeField] GameObject backToMenuCanvas;

    bool creditRollDone = false;

    void Start()
    {
        backToMenuCanvas.SetActive(false);

        float currentOffset = topOffset;

        foreach (Transform name in nameList)
        {
            name.position += new Vector3(0, currentOffset, 0);
            currentOffset -= nameSeparation;
        }

        currentOffset += nameSeparation;
        bottomOffset -= currentOffset;
    }

    void Update()
    {
        if (creditRollDone)
            return;
        
        oceanPic.color = Color.Lerp(oceanPic.color, Color.white, fadeSpeed * Time.deltaTime);

        if (nameList.localPosition.y > bottomOffset)
        {
            creditRollDone = true;
            backToMenuCanvas.SetActive(true);
        }
        else
        {
            nameList.position += new Vector3(0, scrollSpeed, 0) * Time.deltaTime;
        }
    }
}

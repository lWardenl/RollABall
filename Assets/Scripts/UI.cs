using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    private int Count;

    public TextMeshProUGUI countText;

    public GameObject winTextObject;




    void Start()
    {
        Count = 0;
        SetCountText();
        winTextObject.SetActive(false);
    }

    void SetCountText()
    {
        countText.text = "Count: " + Count.ToString();
        if (Count >= 3)
        {
            winTextObject.SetActive(true);
        }
    }
        

    private void OnTriggerEnter(Collider Other)
    {
        Count = Count + 1;
        SetCountText();
    }
}

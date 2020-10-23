using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private int Count;

    public TextMeshProUGUI countText;



    void Start()
    {
        Count = 0;
        SetCountText();
    }

    void SetCountText()
    {
        countText.text = "Count: " + Count.ToString();
        
    }
        

    private void OnTriggerEnter(Collider Other)
    {
        Count = Count + 1;
        SetCountText();
    }
}

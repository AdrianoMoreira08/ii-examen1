using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayWin : MonoBehaviour
{
    TextMeshProUGUI displayText;
    // Start is called before the first frame update
    void Start()
    {
        displayText = GetComponent<TextMeshProUGUI>();
        displayText.text = "Score: 0";
    }

    void UpdateText()
    {
        displayText.text = "HAS GANADO!";
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DrawTile : MonoBehaviour
{
    public Color tileColor; 
    private TextMeshProUGUI numText;
    public int number;
    private Image image;

    public void Paint()
    {
        numText = GetComponentInChildren<TextMeshProUGUI>();
        numText.color = tileColor;
        if (number > 0) numText.text = number.ToString();
    }

    //private void OnValidate()
    //{
    //    numText = GetComponentInChildren<TextMeshProUGUI>();
    //    numText.color = tileColor;
    //    if (number > 0) numText.text = number.ToString();
    //    else numText.text = "";
    //}
}

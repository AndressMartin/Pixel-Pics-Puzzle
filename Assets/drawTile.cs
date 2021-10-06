using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DrawTile : MonoBehaviour, IPointerClickHandler
{
    public Color tileColor; 
    private TextMeshProUGUI numText;
    public int number;
    public bool occupied;
    private Image image;

    public void Paint()
    {
        numText = GetComponentInChildren<TextMeshProUGUI>();
        numText.color = tileColor;
        if (number > 0) numText.text = number.ToString();
        else numText.text = "";
    }

    private void OnValidate()
    {
        numText = GetComponentInChildren<TextMeshProUGUI>();
        //numText = GetComponentInChildren<TextMeshProUGUI>();
        //numText.color = tileColor;
        if (number > 0) numText.text = number.ToString();
        else numText.text = "";
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Click");
        if (eventData.clickCount < 2)
        {
            if (eventData.button == PointerEventData.InputButton.Left)
            {
                Debug.Log("Button left");
            }
            if (eventData.button == PointerEventData.InputButton.Right)
            {
                Debug.Log("Button Right");
            }
        }
        else
        {
            if (eventData.button == PointerEventData.InputButton.Left)
            {
                Debug.Log("Double Click");
            }
        }
    }
}

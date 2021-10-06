using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputManager : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler
{
    private void Update()
    {
        RegisterMouse();
    }

    private void RegisterMouse()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log($"Hit {hit.transform.name}");
                if (hit.transform.GetComponent<DrawTile>() == true)
                {
                    Debug.Log("CLicked DrawTile");
                }
            }

        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("I was clicked");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("I Entered!");
    }
}

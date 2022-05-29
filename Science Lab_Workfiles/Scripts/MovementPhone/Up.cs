using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Up : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool isPressed = false;
    public GameObject player;
    void Update()
    {
        if (isPressed)
        {
            player.transform.Translate(0,0 , 0.6f);
        }
    }
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }
}

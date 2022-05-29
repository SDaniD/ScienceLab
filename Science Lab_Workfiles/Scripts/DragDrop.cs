using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    private Vector3 dragOffset;
    private Camera cam;
    private float mZCoord;

    void Awake()
    {
        cam = Camera.main;
    }

    void OnMouseDown()
    {
        mZCoord = cam.WorldToScreenPoint(gameObject.transform.position).z;
        dragOffset = gameObject.transform.position - GetMousePos();
    }

    void OnMouseDrag()
    {
        transform.position = GetMousePos() + dragOffset;
    }

    Vector3 GetMousePos()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = mZCoord;
        return cam.ScreenToWorldPoint(mousePos);
    }
}

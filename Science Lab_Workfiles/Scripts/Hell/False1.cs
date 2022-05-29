using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class False1 : MonoBehaviour
{
    private Vector3 dragOffset;
    private Camera cam;
    private float mZCoord;
    public static bool truePossition;//
    [SerializeField]
    private Vector3 initialPosition;
    void Start()
    {
        initialPosition = transform.position;
    }
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
    private void OnMouseUp()
    {
       
            transform.position = new Vector3(initialPosition.x, initialPosition.y, initialPosition.z);
            truePossition = false;
        
    }
    Vector3 GetMousePos()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = mZCoord;
        return cam.ScreenToWorldPoint(mousePos);
    }
}

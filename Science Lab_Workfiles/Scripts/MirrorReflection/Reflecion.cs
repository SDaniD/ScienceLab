using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Reflecion : MonoBehaviour
{

    public GameObject candle;

    public static bool truePossition;
    [SerializeField]
    public Transform slot;
    //private Vector2 initialPosition;
    //private Vector2 mousePosition;
    private float deltaX;
    void Start()
    {
       // initialPosition = transform.position;
    }

    // Update is called once per frame
    private void OnMouseDown()
    {

        deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
        //deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;


    }
    private void OnMouseDrag()
    {
       /* mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector1(mousePosition.x - deltaX);*/
    }
    private void OnMouseUp()
    {
        if (Mathf.Abs(transform.position.x - slot.position.x) <= 1f &&
            Mathf.Abs(transform.position.y - slot.position.y) <= 0.5f)
        {
            // transform.position = new Vector2(slot_pedal.position.x, slot_pedal.position.y);
            truePossition = true;
            Debug.Log("true");
        }
    }
}

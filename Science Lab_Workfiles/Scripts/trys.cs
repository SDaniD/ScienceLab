using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trys : MonoBehaviour
{
    Vector3 startPos;
    Vector3 dist;
    void OnMouseDown()
    {
        startPos = Camera.main.WorldToScreenPoint(transform.position);
        dist = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, startPos.y, startPos.z));
    }

    void OnMouseDrag()
    {



        Vector3 lastPos = new Vector3(Input.mousePosition.x, startPos.y, startPos.z);
        transform.position = Camera.main.ScreenToWorldPoint(lastPos) + dist;

        while (transform.position.x > 5.71f)
        {
            Vector3 start = new Vector3(5.71f, 1f, 0f);
            transform.position = start;
        }
        while ( transform.position.x < 0.5f)
        {
            Vector3 start = new Vector3(0.5f, 1f, 0f);
            transform.position = start;
        }




    }
}

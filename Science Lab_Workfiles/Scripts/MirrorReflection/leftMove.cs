using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftMove : MonoBehaviour
{
    Vector3 startPos;
    Vector3 dist;
    public GameObject right;
    public GameObject fire;
    void OnMouseDown()
    {
        startPos = Camera.main.WorldToScreenPoint(transform.position);
        dist = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, startPos.y, startPos.z));
    }
    void OnMouseDrag()
    {
        Vector3 lastPos = new Vector3(Mathf.Round(Input.mousePosition.x), startPos.y, startPos.z);
        transform.position = Camera.main.ScreenToWorldPoint(lastPos) + dist;
        Match();
        while (transform.position.x < -5.71f)
        {
            Vector3 start = new Vector3(-5.71f, 0.06f, -0.4f);
            transform.position = start;
        }
        while (transform.position.x > -0.6f)
        {
            Vector3 start = new Vector3(-0.6f, 0.06f, -0.4f);
            transform.position = start;
        }
       

    }
    private void Match()
    {
        bool inside = false;
        float l = right.transform.position.x;//-
        float r = transform.position.x;//+
        float sum = l + r;
        if (sum < 0) { sum = -(l + r); }
        if (sum < 0.2f)
        {
            fire.SetActive(true);
            inside = true;
            print("show");

        }
        if (sum > 0.2f)
        {
            fire.SetActive(false);
            inside = false;


        }
        print(inside);
    }
}

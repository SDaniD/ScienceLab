using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class True1 : MonoBehaviour
{
    private Vector3 dragOffset;
    private Camera cam;
    private float mZCoord;
    public static bool truePossition;//
    public GameObject[] a = new GameObject[7];
    public GameObject[] slots = new GameObject[7];
    public GameObject congrates;
    public GameObject next;

    int s = 0;
    [SerializeField]
    public Transform slot;
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
        if (Mathf.Abs(transform.position.x - slot.position.x) <= 0.3f &&
           Mathf.Abs(transform.position.y - slot.position.y) <= 0.3f &&
            Mathf.Abs(transform.position.z - slot.position.z) <= 0.3f)
        {
            transform.position = new Vector3(slot.position.x, slot.position.y, slot.position.z);
            truePossition = true;
            Debug.Log("true");
            for (int i = 0; i < 8; i++)
            {
                if (a[i].transform.position == slots[i].transform.position)
                {
                    s++;
                }
                if (s == 8)
                {
                    congrates.SetActive(true);
                    next.SetActive(true);
                    print("TRUE");
                }
                else
                {
                    congrates.SetActive(false);
                    next.SetActive(false);

                }
                print(s);
            }
            s = 0;


        }
        else
        {
            transform.position = new Vector3(initialPosition.x, initialPosition.y, initialPosition.z);
            truePossition = false;
            congrates.SetActive(false);
            next.SetActive(false);
        }
    }
    Vector3 GetMousePos()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = mZCoord;
        return cam.ScreenToWorldPoint(mousePos);
    }
}

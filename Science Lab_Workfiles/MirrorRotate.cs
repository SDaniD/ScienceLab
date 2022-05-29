using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorRotate : MonoBehaviour
{
    public float rotateSpeed = 10f;
    void FixedUpdate()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform)
                {
                    print(hit.transform.gameObject.name);
                    if (hit.transform.gameObject.name == "Mirror1" || hit.transform.gameObject.name == "Mirror2" || hit.transform.gameObject.name == "Mirror3")
                    {
                        hit.transform.Rotate(Vector3.down * rotateSpeed * Time.deltaTime);
                    }
                }
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateSpeed = 1000f;
    public MeshRenderer mir1, mir2, mir3;
    void FixedUpdate()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.anyKeyDown)
        {
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform)
                {
                    print(hit.transform.gameObject.name);
                    if (hit.transform.gameObject.name == "Mirror1")
                    {
                        mir1.transform.Rotate ( Vector3.forward * rotateSpeed * Time.deltaTime);
                    }
                    if (hit.transform.gameObject.name == "Mirror2")
                    {
                        mir2.transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
                    }
                    if (hit.transform.gameObject.name == "Mirror3")
                    {
                        mir3.transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
                    }
                }
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    LoadScene scene;
    void Update()
    {
        Transform cam = Camera.main.transform;
        Ray ray = new Ray(cam.position, cam.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 500))
        {
            if (hit.transform.gameObject.name == "start")
            {
                print(hit.transform.gameObject.name);
                if (Input.GetMouseButton(0))
                {
                    Cursor.lockState = CursorLockMode.Confined;
                    scene.SceneLoader(4);
                }
            }
        }
    }
}

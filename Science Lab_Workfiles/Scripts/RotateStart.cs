using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateStart : MonoBehaviour
{
    public float rotateSpeed = 10f;
    void Update()
    {
        transform.Rotate(Vector3.down * rotateSpeed * Time.deltaTime);
    }
}

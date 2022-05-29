using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mass : MonoBehaviour
{
    public Vector3 centerOfMass;
    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().centerOfMass = centerOfMass;
        centerOfMass.y = -1.5f;

        GetComponent<Rigidbody>().WakeUp();
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(GetComponent<Rigidbody>().worldCenterOfMass, 0.5f);
    }

}

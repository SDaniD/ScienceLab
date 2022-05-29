using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posCub : MonoBehaviour
{
   // bool pos;
   
    public Vector3 initialPosition;
    private int x;
    public Rigidbody m_Rigidbody;
    public GameObject cube;
    private bool rotate;
    public Transform target;
    private void OnMouseUp()
    {
        //positions
        if (transform.position.x <= 0 &&
            transform.position.x >= -1.8f)
        {
            transform.position = new Vector3(-1.3f, transform.position.y, transform.position.z);
            Debug.Log("move");
        }
        if (transform.position.x < -1.8f
            && transform.position.x >= -3.5f)
        {
            transform.position = new Vector3(-2.8f, transform.position.y, transform.position.z);
            Debug.Log("move2");
        }
        if (transform.position.x < -3.5f
            && transform.position.x >= -4.9f)
        {
            transform.position = new Vector3(-4.2f, transform.position.y, transform.position.z);
            Debug.Log("move2");
        }
        if (transform.position.x < -4.9f
            && transform.position.x >= -6.3f)
        {
            transform.position = new Vector3(-5.5f, transform.position.y, transform.position.z);
            Debug.Log("move2");
        }
        //
        if (transform.position.x >= 0 &&
            transform.position.x <= 1.8f)
        {
            transform.position = new Vector3(1.3f, transform.position.y, transform.position.z);
            Debug.Log("move");
        }
        if (transform.position.x > 1.8f
            && transform.position.x <= 3.5f)
        {
            transform.position = new Vector3(2.8f, transform.position.y, transform.position.z);
            Debug.Log("move2");
        }
        if (transform.position.x > 3.5f
            && transform.position.x <= 4.9f)
        {
            transform.position = new Vector3(4.2f, transform.position.y, transform.position.z);
            Debug.Log("move2");
        }
        if (transform.position.x > 4.9f
            && transform.position.x <= 6.3f)
        {
            transform.position = new Vector3(5.5f, transform.position.y, transform.position.z);
            Debug.Log("move2");
        }

    }
    private void OnMouseDown()
    {
 
        m_Rigidbody = GetComponent<Rigidbody>();
        if(Mathf.Abs(transform.position.x +cube.transform.position.x) <= 1f)
        {
           // transform.position = new Vector3(-5.4f, transform.position.y, transform.position.z);
          // Debug.Log("trueLeft");
         //   pos = true;  
            m_Rigidbody.freezeRotation = true; 
            Debug.Log(Mathf.Abs(transform.position.x + cube.transform.position.x));
        }
        else
        {
            m_Rigidbody.freezeRotation = false;
            Debug.Log("false");
        }
       
      
    }
  
}

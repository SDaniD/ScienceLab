using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class h50 : MonoBehaviour
{
    
    public GameObject q2;
    public GameObject q3;
    public GameObject q4;
    // Start is called before the first frame update
    public void click1()
    {
       int hide = Random.Range(2, 4);
       int hide2 = Random.Range(2, 4);
        while (hide == hide2)
        {
            hide2 = Random.Range(1, 4);
        }
      
        if (hide == 2 || hide2 == 2)
        {
            q2.SetActive(false);
        }
        if (hide == 3 || hide2 == 3)
        {
            q3.SetActive(false);
        }
        if (hide == 4 || hide2 == 4)
        {
            q4.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

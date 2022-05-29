using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hints : MonoBehaviour
{
    public GameObject Phone1;
    public GameObject Audience1;
    public GameObject H501;
    public GameObject Phone2;
    public GameObject Audience2;
    public GameObject H502;
    public GameObject Phone3;
    public GameObject Audience3;
    public GameObject H503;
    bool phone = false;
    bool audience = false;
    bool h50 = false;
    
    // Start is called before the first frame update
  

    // Update is called once per frame
    public void question1()
    {
        if (phone == true)
        {
            Phone1.SetActive(false);
        }
        if (audience == true)
        {
            Audience1.SetActive(false);
        }
        if (h50 == true)
        {
            H501.SetActive(false);
        }
    }
    public void question2()
    {
        if (phone == true)
        {
            Phone2.SetActive(false);
        }
        if (audience == true)
        {
            Audience2.SetActive(false);
        }
        if (h50 == true)
        {
            H502.SetActive(false);
        }
    }
    public void question3()
    {
        if (phone == true)
        {
            Phone3.SetActive(false);
        }
        if (audience == true)
        {
            Audience3.SetActive(false);
        }
        if (h50 == true)
        {
            H503.SetActive(false);
        }
    }
    public void audiences()
    {
        audience = true;
    }
    public void h50s()
    {
        h50 = true;
    }
    public void phones()
    {
        phone = true;
    }
}

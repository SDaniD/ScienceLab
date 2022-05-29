using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
   
   
    public Toggle toggle1;
    public Toggle toggle2;
    public Toggle toggle3;
    public Toggle toggle4;
    // Start is called before the first frame update
   
    public void answ1()
    {
        toggle2.isOn=false;
        toggle3.isOn = false;
        toggle4.isOn = false;
    }
    public void answ2()
    {
        toggle1.isOn = false;
        toggle3.isOn = false;
        toggle4.isOn = false;
    }
    public void answ3()
    {
        toggle2.isOn = false;
        toggle1.isOn = false;
        toggle4.isOn = false;
    }
    public void answ4()
    {
        toggle2.isOn = false;
        toggle3.isOn = false;
        toggle1.isOn = false;
    }


}

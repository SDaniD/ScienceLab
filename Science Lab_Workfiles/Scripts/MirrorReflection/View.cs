using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class View : MonoBehaviour
{
    public MeshRenderer view;
    public Slider viewSlider;
    public float moveForce;
    public void OnValueChange()
    {
        float movement = viewSlider.value;
        view.transform.position += new Vector3(movement, 0, 0) * moveForce * Time.deltaTime;
        /*if (viewSlider.value == 0)
        {
            view.transform.rotation = view.transform.rotation;
        }
        else if (viewSlider.value < 0)
        {
            view.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (viewSlider.value > 0)
        {
            view.transform.rotation = Quaternion.Euler(0, 180, 0);
        }*/
    }
    public void resetSlider()
    {
        //viewSlider.value = 0;
    }
}

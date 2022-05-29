using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorModifier : MonoBehaviour
{
    public MeshRenderer col1, col2, col3, redLight, greenLight, blueLight;
    public Slider red, green, blue;
    public void OnEdit()
    {
        Color colour = col1.material.color;
        colour.r = red.value;
        colour.g = green.value;
        colour.b = blue.value;
        colour.a = 1;
        col1.material.color = colour;
        col1.material.SetColor("_EmissionColor", colour);
        col2.material.color = colour;
        col2.material.SetColor("_EmissionColor", colour);
        col3.material.color = colour;
        col3.material.SetColor("_EmissionColor", colour);
    }
    public void OnEditRed()
    {
        Color colour = redLight.material.color;
        colour.r = red.value;
        if (red.value == 0)
        {
            colour.a = 0;
        }
        else
        {
            colour.a = 1;
        }
        redLight.material.color = colour;
        redLight.material.SetColor("_EmissionColor", colour);
    }
    public void OnEditGreen()
    {
        Color colour = greenLight.material.color;
        colour.g = green.value;
        if (green.value == 0)
        {
            colour.a = 0;
        }
        else
        {
            colour.a = 1;
        }
        greenLight.material.color = colour;
        greenLight.material.SetColor("_EmissionColor", colour);
    }
    public void OnEditBlue()
    {
        Color colour = blueLight.material.color;
        colour.b = blue.value;
        if (blue.value == 0)
        {
            colour.a = 0;
        }
        else
        {
            colour.a = 1;
        }
        blueLight.material.color = colour;
        blueLight.material.SetColor("_EmissionColor", colour);
    }
}

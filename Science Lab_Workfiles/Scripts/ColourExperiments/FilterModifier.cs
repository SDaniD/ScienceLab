using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FilterModifier : MonoBehaviour
{
    public Filter Filter;
    public MeshRenderer lightF, color1, color2, color3;
    public Slider lightSlider;
    float lightHue;
    public void Update()
    {
        Color color = lightF.material.color;
        if (lightSlider.value == 1)
        {
            color.a = 1;
            color.r = 255;
            color.g = 0;
            color.b = 0;
            lightF.material.color = color;
            lightF.material.SetColor("_EmissionColor", color);
            if (Filter.filterOn == false)
            {
                color1.material.color = color;
                color1.material.SetColor("_EmissionColor", color);
                color2.material.color = color;
                color2.material.SetColor("_EmissionColor", color);
                color3.material.color = color;
                color3.material.SetColor("_EmissionColor", color);
            }
            else if(Filter.filterOn==true && Filter.currFilter==1)
            {
                Filter.onRed();
            }
            else
            {
                color.a = 0;
                color1.material.color = color;
                color1.material.SetColor("_EmissionColor", color);
                color2.material.color = color;
                color2.material.SetColor("_EmissionColor", color);
                color3.material.color = color;
                color3.material.SetColor("_EmissionColor", color);
            }
        }
        else if (lightSlider.value == 2)
        {
            color.a = 1;
            color.r = 255;
            color.g = 255;
            color.b = 0;
            lightF.material.color = color;
            lightF.material.SetColor("_EmissionColor", color);
            if (Filter.filterOn == false)
            {
                color1.material.color = color;
                color1.material.SetColor("_EmissionColor", color);
                color2.material.color = color;
                color2.material.SetColor("_EmissionColor", color);
                color3.material.color = color;
                color3.material.SetColor("_EmissionColor", color);
            }
            else if (Filter.filterOn == true && Filter.currFilter == 2)
            {
                Filter.onYellow();
            }
            else
            {
                color.a = 0;
                color1.material.color = color;
                color1.material.SetColor("_EmissionColor", color);
                color2.material.color = color;
                color2.material.SetColor("_EmissionColor", color);
                color3.material.color = color;
                color3.material.SetColor("_EmissionColor", color);
            }
        }
        else if (lightSlider.value == 3)
        {
            color.a = 1;
            color.b = 0;
            color.g = 255;
            color.r = 0;
            lightF.material.color = color;
            lightF.material.SetColor("_EmissionColor", color);
            if (Filter.filterOn == false)
            {
                color1.material.color = color;
                color1.material.SetColor("_EmissionColor", color);
                color2.material.color = color;
                color2.material.SetColor("_EmissionColor", color);
                color3.material.color = color;
                color3.material.SetColor("_EmissionColor", color);
            }
            else if (Filter.filterOn == true && Filter.currFilter == 3)
            {
                Filter.onGreen();
            }
            else
            {
                color.a = 0;
                color1.material.color = color;
                color1.material.SetColor("_EmissionColor", color);
                color2.material.color = color;
                color2.material.SetColor("_EmissionColor", color);
                color3.material.color = color;
                color3.material.SetColor("_EmissionColor", color);
            }
        }
        else if (lightSlider.value == 4)
        {
            color.a = 1;
            color.r = 0;
            color.b = 255;
            color.g = 255;
            lightF.material.color = color;
            lightF.material.SetColor("_EmissionColor", color);
            if (Filter.filterOn == false)
            {
                color1.material.color = color;
                color1.material.SetColor("_EmissionColor", color);
                color2.material.color = color;
                color2.material.SetColor("_EmissionColor", color);
                color3.material.color = color;
                color3.material.SetColor("_EmissionColor", color);
            }
            else if (Filter.filterOn == true && Filter.currFilter == 4)
            {
                Filter.onCyan();
            }
            else
            {
                color.a = 0;
                color1.material.color = color;
                color1.material.SetColor("_EmissionColor", color);
                color2.material.color = color;
                color2.material.SetColor("_EmissionColor", color);
                color3.material.color = color;
                color3.material.SetColor("_EmissionColor", color);
            }
        }
        else if (lightSlider.value == 5)
        {
            color.a = 1;
            color.r = 0;
            color.g = 0;
            color.b = 255;
            lightF.material.color = color;
            lightF.material.SetColor("_EmissionColor", color);
            if (Filter.filterOn == false)
            {
                color1.material.color = color;
                color1.material.SetColor("_EmissionColor", color);
                color2.material.color = color;
                color2.material.SetColor("_EmissionColor", color);
                color3.material.color = color;
                color3.material.SetColor("_EmissionColor", color);
            }
            else if (Filter.filterOn == true && Filter.currFilter == 5)
            {
                Filter.onBlue();
            }
            else
            {
                color.a = 0;
                color1.material.color = color;
                color1.material.SetColor("_EmissionColor", color);
                color2.material.color = color;
                color2.material.SetColor("_EmissionColor", color);
                color3.material.color = color;
                color3.material.SetColor("_EmissionColor", color);
            }
        }
        else if (lightSlider.value == 6)
        {
            color.a = 1;
            color.r = 255;
            color.g = 0;
            color.b = 255;
            lightF.material.color = color;
            lightF.material.SetColor("_EmissionColor", color);
            if (Filter.filterOn == false)
            {
                color1.material.color = color;
                color1.material.SetColor("_EmissionColor", color);
                color2.material.color = color;
                color2.material.SetColor("_EmissionColor", color);
                color3.material.color = color;
                color3.material.SetColor("_EmissionColor", color);
            }
            else if (Filter.filterOn == true && Filter.currFilter == 6)
            {
                Filter.onMagenta();
            }
            else
            {
                color.a = 0;
                color1.material.color = color;
                color1.material.SetColor("_EmissionColor", color);
                color2.material.color = color;
                color2.material.SetColor("_EmissionColor", color);
                color3.material.color = color;
                color3.material.SetColor("_EmissionColor", color);
            }
        }
        else
        {
            color.a = 0;
            lightF.material.color = color;
            lightF.material.SetColor("_EmissionColor", color);
            if (Filter.filterOn == false)
            {
                color1.material.color = color;
                color1.material.SetColor("_EmissionColor", color);
                color2.material.color = color;
                color2.material.SetColor("_EmissionColor", color);
                color3.material.color = color;
                color3.material.SetColor("_EmissionColor", color);
            }
            else
            {
                Filter.FixedUpdate();
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Filter : MonoBehaviour
{
    
    public MeshRenderer red, yellow, green, cyan, blue, magenta, color1, color2, color3, lightF;
    public Transform filterPos;
    public Slider lightSlider;
    public bool filterOn=false;
    public static int currFilter = 0;
    private void Start()
    {
        red.transform.position = new Vector3 (-1.58f,-1.87f,-0.3f);
        yellow.transform.position = new Vector3(-0.880f, -1.87f, -0.3f);
        green.transform.position = new Vector3(-0.180f, -1.87f, -0.3f);
        cyan.transform.position = new Vector3(0.519999f, -1.87f, -0.3f);
        blue.transform.position = new Vector3(1.22f, -1.87f, -0.3f);
        magenta.transform.position = new Vector3(1.92f, -1.87f, -0.3f);
    }
    public void FixedUpdate()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform)
                {
                    if (hit.transform.gameObject.name=="red")
                    {
                        print(hit.transform.gameObject.name);
                        currFilter = 1;
                        if (red.transform.position != filterPos.position && filterOn == false)
                        {
                            onRed();
                        }
                        else
                        {
                            red.transform.position = new Vector3(-1.58f, -1.87f, -0.3f);
                            filterOn = false;
                            currFilter = 0;
                        }
                    }
                    else if (hit.transform.gameObject.name == "yellow")
                    {
                        print(hit.transform.gameObject.name);
                        currFilter = 2;
                        if (yellow.transform.position != filterPos.position && filterOn == false)
                        {
                            onYellow();
                        }
                        else
                        {
                            yellow.transform.position = new Vector3(-0.880f, -1.87f, -0.3f);
                            filterOn = false;
                            currFilter = 0;
                        }
                    }
                    else if (hit.transform.gameObject.name == "green")
                    {
                        print(hit.transform.gameObject.name);
                        currFilter = 3;
                        if (green.transform.position != filterPos.position && filterOn == false)
                        {
                            onGreen();
                        }
                        else
                        {
                            green.transform.position = new Vector3(-0.180f, -1.87f, -0.3f);
                            filterOn = false;
                            currFilter = 0;
                        }
                    }
                    else if (hit.transform.gameObject.name == "cyan")
                    {
                        print(hit.transform.gameObject.name);
                        currFilter = 4;
                        if (cyan.transform.position != filterPos.position && filterOn == false)
                        {
                            onCyan();
                        }
                        else
                        {
                            cyan.transform.position = new Vector3(0.519999f, -1.87f, -0.3f);
                            filterOn = false;
                            currFilter = 0;
                        }
                    }
                    else if (hit.transform.gameObject.name == "blue")
                    {
                        print(hit.transform.gameObject.name);
                        currFilter = 5;
                        if (blue.transform.position != filterPos.position && filterOn == false)
                        {
                            onBlue();
                        }
                        else
                        {
                            blue.transform.position = new Vector3(1.22f, -1.87f, -0.3f);
                            filterOn = false;
                            currFilter = 0;
                        }
                    }
                    else if (hit.transform.gameObject.name == "magenta")
                    {
                        print(hit.transform.gameObject.name);
                        currFilter = 6;
                        if (magenta.transform.position != filterPos.position && filterOn == false)
                        {
                            onMagenta();
                        }
                        else
                        {
                            magenta.transform.position = new Vector3(1.92f, -1.87f, -0.3f);
                            filterOn = false;
                            currFilter = 0;
                        }
                    }

                }
            }
        }
        
    }
    public void onRed()
    {
        Color color = lightF.material.color;
        red.transform.position = filterPos.position;
        filterOn = true;
        if (lightSlider.value == 1)
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
            color.a = 0;
            color1.material.color = color;
            color1.material.SetColor("_EmissionColor", color);
            color2.material.color = color;
            color2.material.SetColor("_EmissionColor", color);
            color3.material.color = color;
            color3.material.SetColor("_EmissionColor", color);
        }
    }
    public void onYellow()
    {
        Color color = lightF.material.color;
        yellow.transform.position = filterPos.position;
        filterOn = true;
            if (lightSlider.value == 2)
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
                color.a = 0;
            color1.material.color = color;
            color1.material.SetColor("_EmissionColor", color);
            color2.material.color = color;
            color2.material.SetColor("_EmissionColor", color);
            color3.material.color = color;
            color3.material.SetColor("_EmissionColor", color);
        }
    }
    public void onGreen()
    {
        Color color = lightF.material.color;
        green.transform.position = filterPos.position;
            filterOn = true;
            if (lightSlider.value == 3)
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
                color.a = 0;
            color1.material.color = color;
            color1.material.SetColor("_EmissionColor", color);
            color2.material.color = color;
            color2.material.SetColor("_EmissionColor", color);
            color3.material.color = color;
            color3.material.SetColor("_EmissionColor", color);
        }
    }
    public void onCyan()
    {
        Color color = lightF.material.color;
       cyan.transform.position = filterPos.position;
            filterOn = true;
            if (lightSlider.value == 4)
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
                color.a = 0;
            color1.material.color = color;
            color1.material.SetColor("_EmissionColor", color);
            color2.material.color = color;
            color2.material.SetColor("_EmissionColor", color);
            color3.material.color = color;
            color3.material.SetColor("_EmissionColor", color);
        }
    }
    public void onBlue()
    {
        Color color = lightF.material.color;
        blue.transform.position = filterPos.position;
            filterOn = true;
            if (lightSlider.value == 5)
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
                color.a = 0;
            color1.material.color = color;
            color1.material.SetColor("_EmissionColor", color);
            color2.material.color = color;
            color2.material.SetColor("_EmissionColor", color);
            color3.material.color = color;
            color3.material.SetColor("_EmissionColor", color);
        }
    }
    public void onMagenta()
    {
        Color color = lightF.material.color;
        magenta.transform.position = filterPos.position;
            filterOn = true;
            if (lightSlider.value == 6)
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
                color.a = 0;
            color1.material.color = color;
            color1.material.SetColor("_EmissionColor", color);
            color2.material.color = color;
            color2.material.SetColor("_EmissionColor", color);
            color3.material.color = color;
            color3.material.SetColor("_EmissionColor", color);
        }
    }
}

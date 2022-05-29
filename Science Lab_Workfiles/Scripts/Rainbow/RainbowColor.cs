using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainbowColor : MonoBehaviour
{
    public MeshRenderer red, yellow, green, cyan, blue, magenta, currCol;
    public GameObject msg;
    bool redB, yellowB, greenB, cyanB, blueB, magentaB;
    private void Start()
    {
        msg.SetActive(false);
    }
    public void FixedUpdate()
    {
        Color color = red.material.color;
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform)
                {
                    if (hit.transform.gameObject.name == "red" && redB == true)
                    {
                        msg.SetActive(false);
                        color.r = 255;
                        color.g = 0;
                        color.b = 0;
                        red.material.color = color;
                        red.material.SetColor("_EmissionColor", color);
                    }
                    else if (hit.transform.gameObject.name == "red" && redB == false)
                    {
                        msg.SetActive(true);
                    }
                    if (hit.transform.gameObject.name == "yellow" && yellowB == true)
                    {
                        msg.SetActive(false);
                        color.r = 255;
                        color.g = 255;
                        color.b = 0;
                        yellow.material.color = color;
                        yellow.material.SetColor("_EmissionColor", color);
                    }
                    else if (hit.transform.gameObject.name == "yellow" && yellowB == false)
                    {
                        msg.SetActive(true);
                    }
                    if (hit.transform.gameObject.name == "green" && greenB == true)
                    {
                        msg.SetActive(false);
                        color.b = 0;
                        color.g = 255;
                        color.r = 0;
                        green.material.color = color;
                        green.material.SetColor("_EmissionColor", color);
                    }
                    else if (hit.transform.gameObject.name == "green" && greenB == false)
                    {
                        msg.SetActive(true);
                    }
                    if (hit.transform.gameObject.name == "cyan" && cyanB == true)
                    {
                        msg.SetActive(false);
                        color.r = 0;
                        color.b = 255;
                        color.g = 255;
                        cyan.material.color = color;
                        cyan.material.SetColor("_EmissionColor", color);
                    }
                    else if (hit.transform.gameObject.name == "cyan" && cyanB == false)
                    {
                        msg.SetActive(true);
                    }
                    if (hit.transform.gameObject.name == "blue" && blueB == true)
                    {
                        msg.SetActive(false);
                        color.r = 0;
                        color.g = 0;
                        color.b = 255;
                        blue.material.color = color;
                        blue.material.SetColor("_EmissionColor", color);
                    }
                    else if (hit.transform.gameObject.name == "blue" && blueB == false)
                    {
                        msg.SetActive(true);
                    }
                    if (hit.transform.gameObject.name == "magenta" && magentaB == true)
                    {
                        msg.SetActive(false);
                        color.r = 255;
                        color.g = 0;
                        color.b = 255;
                        magenta.material.color = color;
                        magenta.material.SetColor("_EmissionColor", color);
                    }
                    else if (hit.transform.gameObject.name == "magenta" && magentaB == false)
                    {
                        msg.SetActive(true);
                    }
                }
            }
        }
    }
    public void redButton()
    {
        Color color = red.material.color;
        color.r = 255;
        color.g = 0;
        color.b = 0;
        currCol.material.color = color;
        currCol.material.SetColor("_EmissionColor", color);
        redB = true;
        yellowB = false;
        greenB = false;
        cyanB = false;
        blueB = false;
        magentaB = false;
        msg.SetActive(false);
    }
    public void yellowButton()
    {
        Color color = red.material.color;
        color.r = 255;
        color.g = 255;
        color.b = 0;
        currCol.material.color = color;
        currCol.material.SetColor("_EmissionColor", color);
        redB = false;
        yellowB = true;
        greenB = false;
        cyanB = false;
        blueB = false;
        magentaB = false;
        msg.SetActive(false);
    }
    public void greenButton()
    {
        Color color = red.material.color;
        color.b = 0;
        color.g = 255;
        color.r = 0;
        currCol.material.color = color;
        currCol.material.SetColor("_EmissionColor", color);
        redB = false;
        yellowB = false;
        greenB = true;
        cyanB = false;
        blueB = false;
        magentaB = false;
        msg.SetActive(false);
    }
    public void cyanButton()
    {
        Color color = red.material.color;
        color.r = 0;
        color.b = 255;
        color.g = 255;
        currCol.material.color = color;
        currCol.material.SetColor("_EmissionColor", color);
        redB = false;
        yellowB = false;
        greenB = false;
        cyanB = true;
        blueB = false;
        magentaB = false;
        msg.SetActive(false);
    }
    public void blueButton()
    {
        Color color = red.material.color;
        color.r = 0;
        color.g = 0;
        color.b = 255;
        currCol.material.color = color;
        currCol.material.SetColor("_EmissionColor", color);
        redB = false;
        yellowB = false;
        greenB = false;
        cyanB = false;
        blueB = true;
        magentaB = false;
        msg.SetActive(false);
    }
    public void magentaButton()
    {
        Color color = red.material.color;
        color.r = 255;
        color.g = 0;
        color.b = 255;
        currCol.material.color = color;
        currCol.material.SetColor("_EmissionColor", color);
        redB = false;
        yellowB = false;
        greenB = false;
        cyanB = false;
        blueB = false;
        magentaB = true;
        msg.SetActive(false);
    }
}

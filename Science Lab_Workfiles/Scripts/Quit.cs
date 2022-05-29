using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public static void quit()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}

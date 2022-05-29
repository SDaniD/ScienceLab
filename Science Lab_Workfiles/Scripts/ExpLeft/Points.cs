using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public GameObject[] clicked = new GameObject[10];
    int points = 0;
    public GameObject show;
    public void OnMouseDown()
    {

        print("down");
        show.SetActive(true);
      
            for (int i = 0; i <= 9; i++)
            {
                if (clicked[i].activeInHierarchy == true)
                {
                    points++;
                }
                print(points);
            }
        
    }
}

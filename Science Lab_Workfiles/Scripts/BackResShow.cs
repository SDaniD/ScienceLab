using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackResShow : MonoBehaviour
{
    public GameObject res;
    void Update()
    {
        if (ResShow.t)
        {
            res.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptBackResShow : MonoBehaviour
{
    public GameObject res;
    void Update()
    {
        if (OptResShow.t)
        {
            res.SetActive(true);
        }
    }
}

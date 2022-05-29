using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitDoorMech : MonoBehaviour
{
    public GameObject player;
    public GameObject score;
    void OnTriggerEnter(Collider door)
    {
        ResShow.t = false;
        score.SetActive(false);
        player.transform.position = new Vector3(-12.96f, 0.2f, -175.08f);
    }
}

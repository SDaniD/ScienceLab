using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitDoorOpt : MonoBehaviour
{
    public GameObject player;
    public GameObject score;
    void OnTriggerEnter(Collider door)
    {
        OptResShow.t = false;
        score.SetActive(false);
        player.transform.position = new Vector3(-12.96f, 0.2f, -142.6f);
    }
}

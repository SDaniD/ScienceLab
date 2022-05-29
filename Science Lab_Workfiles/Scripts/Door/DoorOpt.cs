using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorOpt : MonoBehaviour
{
    public GameObject player;
    public GameObject score;
    void OnTriggerEnter(Collider door)
    {
        score.SetActive(true);
        player.transform.position = new Vector3(-12.96f, 2.45f, -136.764f);
    }
}

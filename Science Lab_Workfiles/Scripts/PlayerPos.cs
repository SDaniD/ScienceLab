using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPos : MonoBehaviour
{
    public GameObject player;
    float x, y, z;
    void Start()
    {
        Debug.Log("aaa");
        //player.transform.position = new Vector3(-12.96f, 0.2f, -175.08f);
        Debug.Log(PlayerPrefs.GetFloat("x")+" "+PlayerPrefs.GetFloat("y")+" "+ PlayerPrefs.GetFloat("z"));
        player.transform.position = new Vector3(PlayerPrefs.GetFloat("x"),
            PlayerPrefs.GetFloat("y"), PlayerPrefs.GetFloat("z"));
    }
    void Update()
    {
        x = player.transform.position.x;
        y = player.transform.position.y;
        z = player.transform.position.z;
    }
    public void Clear()
    {
        player.transform.position = new Vector3(-12.96f, 0.2f, -175.08f);
        PlayerPrefs.SetFloat("x", -12.96f);
        PlayerPrefs.SetFloat("y", 0.2f);
        PlayerPrefs.SetFloat("z", -175.08f);
    }
    public void PosPlayer()
    {
        PlayerPrefs.SetFloat("x", x);
        PlayerPrefs.SetFloat("y", y);
        PlayerPrefs.SetFloat("z", z);  
    }
}

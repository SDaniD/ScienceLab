using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BallanceToggles : MonoBehaviour
{
    public Toggle t;
    public Transform target1;
    public Transform target2;
    public GameObject[] cubes = new GameObject[2];
    GameObject[] pos = new GameObject[4];
    public GameObject[] weights = new GameObject[2];
    private void Start()
    {
        cubes[0].SetActive(false);
        cubes[1].SetActive(false);
        weights[0].SetActive(false);
        weights[1].SetActive(false);
    }
    public void cube()
    {
        Debug.Log("cube");
        if (t.isOn == true)
        {
            cubes[0].SetActive(true);
            cubes[1].SetActive(true);
        }
        else 
        {
            cubes[0].SetActive(false);
            cubes[1].SetActive(false);
        }
    }
        public void weight()
        {
        Debug.Log("weights");
            if (t.isOn == true)
            {
                weights[0].SetActive(true);
                weights[1].SetActive(true);
        }
        else
        {
            weights[0].SetActive(false);
            weights[1].SetActive(false);
        }
        }
    public void Reload()
    {
        if (t.isOn == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

} 

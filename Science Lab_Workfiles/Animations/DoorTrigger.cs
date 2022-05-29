using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public GameObject door;
    public Animator doorAnim;
    public void ClickDoor()
    {
        doorAnim.SetTrigger("DoorTrigger");
       
    }
}

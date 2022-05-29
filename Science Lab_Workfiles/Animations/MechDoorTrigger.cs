using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechDoorTrigger : MonoBehaviour
{
    public GameObject door;
    public Animator doorAnim;
    public void ClickDoor()
    {
        doorAnim.SetTrigger("MechDoorTrigger");
       
    }
}

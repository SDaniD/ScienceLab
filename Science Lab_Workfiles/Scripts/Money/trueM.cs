using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trueM : MonoBehaviour
{
    public GameObject bravo;
    public GameObject tryAgain;
    public void clickTrue()
    {
        bravo.SetActive(true);
        tryAgain.SetActive(false);
    }
    public void clickFalse()
    {
        bravo.SetActive(false);
        tryAgain.SetActive(true);
    }


}

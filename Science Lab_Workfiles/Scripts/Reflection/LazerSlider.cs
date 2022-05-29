using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LazerSlider : MonoBehaviour
{
    public Slider laserSlider;
    public float zLimit = 90f;

    void Start()
    {
        laserSlider.onValueChanged.AddListener(delegate { laserRotation(); });
    }
    void laserRotation()
    {
        transform.localEulerAngles = new Vector3(0, 0, laserSlider.value*zLimit);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

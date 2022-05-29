using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reticle : MonoBehaviour
{

    private RectTransform reticle;
    public float size;
    void Start()
    {
        reticle = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        reticle.sizeDelta = new Vector2(size, size);
    }
}

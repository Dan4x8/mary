using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeAnimation : MonoBehaviour
{
    RectTransform stick;

    float targetY = -6f;

    // Start is called before the first frame update
    void Start()
    {
        stick = transform.Find("Stick").GetComponent<RectTransform>();

        Debug.Log(stick.gameObject.name);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

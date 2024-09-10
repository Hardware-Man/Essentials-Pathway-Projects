using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleTransform : MonoBehaviour
{
    public Vector3 scaleChange;
    private int reverse = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.x >= 2) reverse = -1;
        if (transform.localScale.x <= 0.5) reverse = 1;
        transform.localScale += scaleChange * reverse * Time.deltaTime;
    }
}

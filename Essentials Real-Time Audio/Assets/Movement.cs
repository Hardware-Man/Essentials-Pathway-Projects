using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    private int dir = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(dir * speed * Time.deltaTime, 0, 0);
        if (transform.position.x >= 4.2)
        {
            dir = -1;
        }
        if (transform.position.x <= 1)
        {
            dir = 1;
        }
    }
}

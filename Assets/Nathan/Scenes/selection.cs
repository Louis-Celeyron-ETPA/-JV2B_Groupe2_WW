using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(2, -1.5f);
        transform.position = new Vector3(-1, -1.5f);
        transform.position = new Vector3(-4, -1.5f);
        transform.position = new Vector3(-7, -1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < 2)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.position += new Vector3(3, 0);
            }
        }
        if (transform.position.x > -7)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-3, 0);
        }
        }
    }
}

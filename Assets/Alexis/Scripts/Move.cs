using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position = new Vector3(transform.position.x - 0.01f , 0f, transform.position.z);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position = new Vector3(transform.position.x + 0.01f, 0f, transform.position.z);
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position = new Vector3(transform.position.x, 0f, transform.position.z + 0.01f);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.position = new Vector3(transform.position.x, 0f, transform.position.z - 0.01f);
            }
    }
}

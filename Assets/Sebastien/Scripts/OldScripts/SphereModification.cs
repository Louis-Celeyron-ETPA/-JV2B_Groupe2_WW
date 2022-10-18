using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereModification : MonoBehaviour
{

    public KeyCode leftKey;
    public KeyCode rightKey;

    Rigidbody rb;
    //public float m_Thrust = 20f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(leftKey))
        {
            rb.AddForce (0, 0,50);

        }


        else if (Input.GetKeyDown(rightKey))
        {
            rb.AddForce(0, 0, 50);

        }

       



    }

    
}

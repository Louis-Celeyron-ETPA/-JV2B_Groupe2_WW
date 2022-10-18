using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInteraction : MonoBehaviour
{
    public KeyCode mainKey;
    public float strength;
    Rigidbody2D rb;

    public bool isThrowing = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        strength = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(mainKey))
        //{
        //    //rb.AddForce(transform.right * strength, ForceMode2D.Impulse);
        //    //rb.AddForce(transform.up * strength, ForceMode2D.Impulse);

        //}

        if (Input.GetKey(mainKey) && isThrowing == false)
        {

            strength += 0.1f;

        }


        else if (Input.GetKeyUp(mainKey) && isThrowing == false)
        {

            rb.AddForce(transform.right * strength, ForceMode2D.Impulse);
            rb.AddForce(transform.up * strength, ForceMode2D.Impulse);
            isThrowing = true;

        }


    }

}

  

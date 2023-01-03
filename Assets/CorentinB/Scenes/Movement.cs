using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    //private Rigidbody2D rb2d;


    // Start is called before the first frame update
    void Start()
    {
        //rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(0.0025f, 0);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -0.0025f);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-0.0025f, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 0.0025f);
        }
        //transform.position = new Vector2(moveHorizontal * speed, moveVertical * speed);

        //rb2d.velocity = new Vector2(moveHorizontal * speed, moveVertical * speed);
        //rb2d.velocity = new Vector2(moveLeft * speed, moveRight * speed);
    }
}

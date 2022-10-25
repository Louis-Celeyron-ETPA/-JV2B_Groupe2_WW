using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls: MonoBehaviour
{
    public Rigidbody2D rgb;
    public KeyCode GoUp;
    public KeyCode GoDown;
    public KeyCode GoLeft;
    public KeyCode GoRight;

    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(GoUp) )
        //{

        //    rgb.velocity = new Vector2(+0, +1);

        //}

        //else if (Input.GetKey(GoDown))
        //{

        //    rgb.velocity = new Vector2(+0, -1);

        //}
        //else if (Input.GetKey(GoLeft))
        //{

        //    rgb.velocity = new Vector2(-1, +0);

        //}

        //else if (Input.GetKey(GoRight))
        //{

        //    rgb.velocity = new Vector2(+1, +0);

        //}

        //else if (Input.GetKeyUp(GoUp) && Input.GetKeyUp(GoDown) && Input.GetKeyUp(GoLeft) && Input.GetKeyUp(GoRight) )
        //{

        //    rgb.velocity = new Vector2(+0, +0);

        //}

        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MooveFusee : MonoBehaviour
{
    //public Rigibody2D rgbd;
    public float Speed = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x >= -4)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                //if (Input.GetKeyDown(KeyCode.LeftArrow)) transform.Translate(new Vector2(-1, 0));
                transform.position += new Vector3(-0.007f, 0);
            }
        }
        if (transform.position.x <= 3.98)
        {

            if (Input.GetKey(KeyCode.RightArrow))
            {
                //if (Input.GetKeyDown(KeyCode.RightArrow)) transform.Translate(new Vector2(1, 0));
                transform.position += new Vector3(0.007f, 0);
            }
        }
            transform.position += new Vector3(0, 0.007f);
    }
}

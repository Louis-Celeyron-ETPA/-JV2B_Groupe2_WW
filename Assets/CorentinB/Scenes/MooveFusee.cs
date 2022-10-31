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
        //rgbd.velocity(new Vector2 = transform.translate(new Vector3(0, 1, 0.12f));

        if (transform.position.x >= -4)
        {
            if (Input.GetKey(KeyCode.LeftArrow)) ;
            {
                //transform.position(Vector2.right * Time.deltaTime * Speed);
                //transform.position = new Vector2(10f, 0);
                //transform.position = new Vector3(7f, transform.position.y, transform.position.z);
                if (Input.GetKeyDown(KeyCode.LeftArrow)) transform.Translate(new Vector2(-1, 0));
            }
        }
        if (transform.position.x <= 3.98)
        {

            if (Input.GetKey(KeyCode.RightArrow)) ;
            {
                //transform.position.x = new Vector2.left;
                if (Input.GetKeyDown(KeyCode.RightArrow)) transform.Translate(new Vector2(1, 0));
            }
        }
        //if (transform.position.y >= -5.52)
        //{
        //  if (Input.GetKey(KeyCode.Space)) ;
        //{
        //  if (Input.GetKeyDown(KeyCode.Space)) transform.Translate(new Vector2(0, 1));
        //}
        //}
        transform.position += new Vector3(0, 0.009f);
    }
}

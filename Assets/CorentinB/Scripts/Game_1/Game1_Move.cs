using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CorentinB_Game1
{
    public class Game1_Move : MonoBehaviour
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

            if (transform.position.x >= -5.17f)
            {
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    //if (Input.GetKeyDown(KeyCode.LeftArrow)) transform.Translate(new Vector2(-1, 0));
                    transform.position += new Vector3(-0.007f, 0);
                }
            }
            if (transform.position.x <= 5.22f)
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
}

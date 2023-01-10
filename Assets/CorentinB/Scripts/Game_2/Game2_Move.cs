using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CorentinB_Game2
{
    public class Game2_Move : MonoBehaviour
    {
        public float speed;

        void Start()
        {

        }

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
        }
    }
}

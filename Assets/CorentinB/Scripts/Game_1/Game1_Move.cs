using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CorentinB_Game1
{
    public class Game1_Move : MonoBehaviour
    {
        //public Rigibody2D rgbd;
        public float Speed = 10f;
        public bool verticalAxisUsed;

        void Update()
        {
            transform.position += new Vector3(0, 0.007f);
        }


        //----------------------------------------------------------------------------------------



        public void MoveFuseeLeft()
        {

            if (transform.position.x >= -5.17f)
            {
                //transform.position += new Vector3(-0.007f, 0);
                transform.position += Vector3.left * 0.007f;
            }
        }
        public void MoveFuseeRight()
        {

            if (transform.position.x <= 5.22f)
            {

                transform.position += new Vector3(0.007f, 0);
            }
        }
        public void Reset()
        {
            verticalAxisUsed = false;
        }
    }
}

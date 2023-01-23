using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CorentinB_Game2
{
    public class Game2_Move : MonoBehaviour
    {
        public float speed;
        public bool verticalAxisUsed;

        void Update()
        {
 
        }

        public void MovePersoLeft()
        { 
                transform.position += new Vector3(-0.0030f, 0); 
        }
        public void MovePersoRight()
        {
                transform.position += new Vector3(0.0030f, 0);  
        }
        public void MovePersoDown()
        {   
                transform.position += new Vector3(0, -0.0030f);
        }
        public void MovePersoUp()
        {
                transform.position += new Vector3(0, 0.0030f);
        }

        public void Reset()
        {
            verticalAxisUsed = false;
        }
    }
}

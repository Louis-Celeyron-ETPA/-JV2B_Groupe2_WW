using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NatanG_minijeu2
{

    public class Déplacement : MonoBehaviour
    {
        public Rigidbody2D rgbd;

        void Update()
        {
            //------------------------------------- Le perso bouge
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rgbd.MovePosition((Vector2)transform.position + Vector2.left * 0.08f);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rgbd.MovePosition((Vector2)transform.position + Vector2.right * 0.08f);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rgbd.MovePosition((Vector2)transform.position + Vector2.up * 0.08f);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                rgbd.MovePosition((Vector2)transform.position + Vector2.down * 0.08f);
            }
        }
    }
}

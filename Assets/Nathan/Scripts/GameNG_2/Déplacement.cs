using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NatanG_minijeu2
{

    public class Déplacement : MonoBehaviour
    {
        public Rigidbody2D rgbd;

        public void GoRight() // Aller à droite
        {
            rgbd.MovePosition((Vector2)transform.position + Vector2.right * 0.08f);
        }
        public void GoLeft() // Aller à gauche
        {
            rgbd.MovePosition((Vector2)transform.position + Vector2.left * 0.08f);
        }
        public void GoUp() // Aller en haut
        {
            rgbd.MovePosition((Vector2)transform.position + Vector2.up * 0.08f);
        }
        public void GoDown() // Aller en bas
        {
            rgbd.MovePosition((Vector2)transform.position + Vector2.down * 0.08f);
        }
    }
}

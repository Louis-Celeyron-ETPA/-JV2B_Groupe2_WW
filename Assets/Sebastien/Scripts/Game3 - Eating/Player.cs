using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace SebastienMiniGame3
{
    public class Player : MonoBehaviour
    {
        public GameObject player;
        private float _speed = 0.02f;
        private Rigidbody2D _rgb;
        public GameObject item;
        private SpriteRenderer _renderer;
        private Animator _anim;

        public KeyCode GoRight;
        public KeyCode GoLeft;

        public Items varStart;



        // Start is called before the first frame update
        void Start()
        {

            player = this.gameObject;
            _renderer = GetComponent<SpriteRenderer>();

            _anim = gameObject.GetComponent<Animator>();
            _anim.Play("Default");

        }

        // Update is called once per frame
        void Update()
        {

            var pos = transform.position;
            //pos.x += 1;
            transform.position = pos;


            if (Input.GetKey(GoRight)) // test sur pc
            {
                MoveRight();
            }
            else if (Input.GetKey(GoLeft))
            {
                MoveLeft();
            }

           
        }

        public void MoveRight()
        {
            print("A droite !!!");
            transform.position += Vector3.right * _speed;
            _renderer.flipX = false;
            _anim.Play("Running");
        }

        public void MoveLeft()
        {
            print("A gauche !!!");
            transform.position += Vector3.left * _speed;
            _renderer.flipX = true;
            _anim.Play("Running");
        }

    }

}

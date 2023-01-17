using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace SebastienMiniGame3 {
    public class Player : MonoBehaviour
    {
        public GameObject player;
        private Rigidbody2D _rgb;
        public GameObject item;
        private SpriteRenderer _renderer;
        private Animator _anim;

        public Items varStart;

      



        // Start is called before the first frame update
        void Start()
        {

            player = this.gameObject;
            _renderer = GetComponent<SpriteRenderer>();

            _anim = gameObject.GetComponent<Animator>();
            _anim.Play("Running");

        }

        // Update is called once per frame
        void Update()
        {
            MovePlayer();

            //Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //if (varStart.gameStart && mousePosition.x > -8 && mousePosition.x < 8)

            //{
            //    player.transform.position = new Vector2(mousePosition.x, -2.1f);

            //}



            //if (mousePosition.x < 0 && varStart.gameStart)

            //{
            //_renderer.flipX = true;

            //}

            //else
            //{

            //    _renderer.flipX = false;

            //}
        }

        public void MovePlayer(string direction)
        {
            _rgb.MovePosition(direction);

        }






    }

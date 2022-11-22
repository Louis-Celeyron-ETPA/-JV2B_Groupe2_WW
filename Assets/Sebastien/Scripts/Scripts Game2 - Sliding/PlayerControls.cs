using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SebastienMiniGame2
{
    public class PlayerControls : MonoBehaviour
    {
        public GameObject player;
        public GameObject victoryGoal;

        public Rigidbody2D rgb;
        public KeyCode GoUp;
        public KeyCode GoDown;
        public KeyCode GoLeft;
        public KeyCode GoRight;

        public float speed;
        public float directionX;
        public float directionY;

        public bool isMoving;


        public bool victory = false;


        // Start is called before the first frame update
        void Start()
        {


        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(GoUp) && rgb.velocity.x == 0f && rgb.velocity.y == 0f)
            {
                directionY += 5f;

                speed = 2f;

                isMoving = true;
            }

            else if (Input.GetKey(GoDown) && rgb.velocity.x == 0f && rgb.velocity.y == 0f)
            {
                directionY -= 5f;

                speed = 2f;

                isMoving = true;
            }
            else if (Input.GetKey(GoLeft) && rgb.velocity.x == 0f && rgb.velocity.y == 0f)
            {

                directionX -= 5f;
                speed = 2f;

                isMoving = true;
            }

            else if (Input.GetKey(GoRight) && rgb.velocity.x == 0f && rgb.velocity.y == 0f)
            {
                directionX += 5f;
                speed = 2f;
                isMoving = true;
            }

            rgb.velocity = new Vector2(directionX, directionY) * speed;

            if (rgb.velocity.x == 0f && rgb.velocity.y == 0f)

            {
                directionX = 0f;
                directionY = 0f;
                speed = 0f;
            }

            //if (speed > 0f && speed <= 2)

            //{
            //    SlowingDown();

            //}




        }

        public void SlowingDown()
        {

            speed -= 0.02f;

        }

        public void OnCollisionEnter2D(Collision2D collision)
        {
            
            if (collision.transform.gameObject.tag == "Obstacle")
            {
                directionX = 0f;
                directionY = 0f;
                speed = 0f;
                isMoving = false;
                Debug.Log("Bonk!");
            }

            else if (collision.transform.gameObject.name == "VictoryGoal")
            {
                collision.gameObject.SetActive(false);
                Debug.Log("GG");
                victory = true;

            }
            

        }

        public void OnTriggerEnter2D(Collider2D collision)
        {

            if (collision.transform.gameObject.tag == "Danger")
            {
                directionX = 0f;
                directionY = 0f;
                speed = 0f;
                isMoving = false;
                Debug.Log("Aïe!");
            }

            


        }
    }


}

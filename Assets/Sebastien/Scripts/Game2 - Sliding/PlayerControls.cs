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

        public KeyCode GoUp; //Test sur PC
        public KeyCode GoDown;
        public KeyCode GoLeft;
        public KeyCode GoRight;

        public float speed;
        public float directionX;
        public float directionY;

        public bool isMoving;
        public bool trapdoorOpened = false;



        public bool victory = false;


        // Start is called before the first frame update
        void Start()
        {


        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(GoUp))
            {
                DirectionPlayerUp();
            }

            else if (Input.GetKeyDown(GoDown))
            {
                DirectionPlayerDown();
            }
            else if (Input.GetKeyDown(GoLeft))
            {

                DirectionPlayerLeft();
            }

            else if (Input.GetKeyDown(GoRight))
            {
                DirectionPlayerRight();
            }



            rgb.velocity = new Vector2(directionX, directionY) * speed;

            
            Debug.Log(isMoving);
            if (rgb.velocity.x == 0f && rgb.velocity.y == 0f)

            {
                directionX = 0f;
                directionY = 0f;
                speed = 0f;
                isMoving = false;
            }

        }

        public void SlowingDown()
        {

            speed -= 0.02f;

        }

        public void OnCollisionEnter2D(Collision2D collision)
        {
            
            if (collision.transform.gameObject.tag == "Obstacle")
            {
                isMoving = false;
                directionX = 0f;
                directionY = 0f;
                speed = 0f;
                rgb.velocity = new Vector3(0,0,0);
                Debug.Log("Bonk!");
            }

            else if (collision.transform.gameObject.name == "VictoryGoal") // Collision de victoire
            {
                collision.gameObject.SetActive(false);
                Debug.Log("GG");
                victory = true;

                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);

            }


        }

        public void OnTriggerEnter2D(Collider2D collision)
        {

            if (collision.transform.gameObject.tag == "Danger") // Collision de défaite
            {
                directionX = 0f;
                directionY = 0f;
                speed = 0f;
                isMoving = false;
                Debug.Log("Aïe!");
                

                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);

            }


        }

        public void DirectionPlayerUp()

        {
            if (!isMoving)
            {
                directionY += 5f;
                speed = 2f;
                isMoving = true;
            }

        }

        public void DirectionPlayerDown()

        {
            if (!isMoving)
            {
                directionY -= 5f;
                speed = 2f;
                isMoving = true;
            }

        }

        public void DirectionPlayerLeft()

        {
            if (!isMoving)
            {
                directionX -= 5f;
                speed = 2f;
                isMoving = true;
            }

        }

        public void DirectionPlayerRight()

        {
            if (!isMoving)
            {
                directionX += 5f;
                speed = 2f;
                isMoving = true;
            }

        }


    }

}




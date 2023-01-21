using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



namespace SebastienMiniGame1
{
    public class Death : MonoBehaviour
    {

        public bool isDead = false;
        public int livesLeft = 3;
        public Text livesLeftDisplay;

        public GameObject lifeHUD1;
        public GameObject lifeHUD2;
        public GameObject lifeHUD3;

        public GameObject player;
        public Rigidbody2D playerRgb;

        public float initialX = -8f;
        public float initialY = -2f;

        public BallInteraction thrownBall;
        public BallInteraction strengthBall;

        void Start()
        {
            livesLeft = 3;
            livesLeftDisplay.text = "Balls Left : " + livesLeft;
            Debug.Log(livesLeft + " vies restantes");
            //player.transform.position = new Vector2(initalX, initalY);

        }

        // Update is called once per frame
        void Update()
        {
            if (isDead && livesLeft > 0)
            {
                Respawn();
            }

            LifeLoss(); //Check constamment le nombre de vies

        }

        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.transform.gameObject.name == "Ball")
            {
                isDead = true;
                livesLeft -= 1; // Perte d'une vie
                livesLeftDisplay.text = "Balls Left : " + livesLeft;

                Debug.Log(livesLeft + " vies restantes");
                player.transform.position = new Vector2(initialX, initialY);
                playerRgb.velocity = new Vector2(0, 0);
                strengthBall.strength = 0f; // Reset force balle
            }

        }

        public void LifeLoss()
        {

            if (livesLeft == 3)
            {
                lifeHUD1.SetActive(true);
                lifeHUD2.SetActive(true);
                lifeHUD3.SetActive(false);
            }
            else if (livesLeft == 2)
            {
                lifeHUD1.SetActive(true);
                lifeHUD2.SetActive(false);
                lifeHUD3.SetActive(false);
            }

            else if (livesLeft == 1)
            {
                lifeHUD1.SetActive(false);
                lifeHUD2.SetActive(false);
                lifeHUD3.SetActive(false);
            }
            else if (livesLeft == 0)
            {
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            }
        }

        public void Respawn()
        {
            isDead = false;
            thrownBall.isThrowing = false;

            

        }
    }

}

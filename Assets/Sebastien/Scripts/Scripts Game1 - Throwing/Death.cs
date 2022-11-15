using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Death : MonoBehaviour
{

    public bool isDead = false;
    public int livesLeft = 3;

    public GameObject lifeHUD1;
    public GameObject lifeHUD2;
    public GameObject lifeHUD3;

    public GameObject player;
    public Rigidbody2D playerRgb;

    public float initalX = -8f;
    public float initalY = -2f;

    public BallInteraction thrownBall;
    public BallInteraction strengthBall;

    // Start is called before the first frame update
    void Start()
    {
        livesLeft = 3;

        Debug.Log(livesLeft + " vies restantes");

        //player.transform.position = new Vector2(initalX, initalY);

    }

    // Update is called once per frame
    void Update()
    {   
        if(isDead && livesLeft > 0)
        {
            Respawn();
        }

       
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.gameObject.name == "Ball")
        {
            isDead = true;
            livesLeft -= 1;
            Debug.Log(livesLeft + " vies restantes");
            LifeLoss();
            player.transform.position = new Vector2(initalX, initalY);
            playerRgb.velocity = new Vector2 (0,0) ;
            strengthBall.strength = 0f;
        }

    }

    public void LifeLoss()
    {

        if (livesLeft == 3)
        {
            lifeHUD1.SetActive(true);
            lifeHUD2.SetActive(true);
            lifeHUD3.SetActive(true);
        }
        else if (livesLeft == 2)
        {
            lifeHUD1.SetActive(true);
            lifeHUD2.SetActive(true);
            lifeHUD3.SetActive(false);
        }

        else if (livesLeft == 1)
        {
            lifeHUD1.SetActive(true);
            lifeHUD2.SetActive(false);
            lifeHUD3.SetActive(false);
        }
        else if (livesLeft == 0)
        {
            lifeHUD1.SetActive(false);
            lifeHUD2.SetActive(false);
            lifeHUD3.SetActive(false);
        }
    }

    public void Respawn()
    {
        isDead = false;
        thrownBall.isThrowing = false;

    }
}

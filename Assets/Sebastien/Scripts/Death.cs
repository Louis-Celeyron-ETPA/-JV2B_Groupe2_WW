using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public bool isDead = false;
    public int livesLeft;

    public GameObject lifeHUD1;
    public GameObject lifeHUD2;
    public GameObject lifeHUD3;

    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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

        if (isDead)
        {
            LifeLoss();
            Respawn();

        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.gameObject.name == "Ball")
        {
            collision.gameObject.SetActive(false);
            isDead = true;
            Debug.Log(livesLeft + " vies restantes");
           
        }

    }

    public void LifeLoss()
    {

        if (livesLeft == 3)
        {
            livesLeft = 2;

        }
        else if (livesLeft == 2)
        {
            livesLeft = 1;
        }

        else if (livesLeft == 1)
        {
            livesLeft = 0;
        }
    }

    public void Respawn()
    {
        if (isDead)
        {
            Instantiate(player, (new Vector2(-7,-1.5f)), transform.rotation);
            isDead = false;
        }

    }
}

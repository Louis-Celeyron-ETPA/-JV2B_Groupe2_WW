using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    public int livesLeft;
    public Death dead;

    public GameObject lifeHUD1;
    public GameObject lifeHUD2;
    public GameObject lifeHUD3;


    void Start()
    {
        dead = FindObjectOfType<Death>();

        livesLeft = 3;

    }

    // Update is called once per frame
    void Update()
    {
        if (dead.isDead == true)
        {
            livesLeft -= 1;
            dead.isDead = false;
            Debug.Log("Mort");


        }

        else if (livesLeft == 3)
        {
            lifeHUD1.SetActive(true);
            lifeHUD2.SetActive(true);
            lifeHUD3.SetActive(true);
        }
        else if (livesLeft == 2)
        {
            lifeHUD1.SetActive(false);
            lifeHUD2.SetActive(true);
            lifeHUD3.SetActive(true);
        }
        
        else if (livesLeft == 1)
        {
            lifeHUD1.SetActive(false);
            lifeHUD2.SetActive(false);
            lifeHUD3.SetActive(true);
        }
    }
}

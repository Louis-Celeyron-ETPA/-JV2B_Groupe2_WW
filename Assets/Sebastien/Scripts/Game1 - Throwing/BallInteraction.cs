using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace SebastienMiniGame1
{
    public class BallInteraction : MonoBehaviour
    {
        public KeyCode actionKey; 
        public float strength;
        public float strengthMax = 10f;

        Rigidbody2D rb;
        public Scrollbar scrollbar;
        public bool isThrowing = false;

        // Start is called before the first frame update
        void Start()
        {

            rb = GetComponent<Rigidbody2D>();
            strength = 1f;
            

        }

        // Update is called once per frame
        void Update()
        {

            // Strength minimum = 0
            // Strength maximum (capée pour ne pas envoyer la balle trop loin) = 10



            if (Input.GetKey(actionKey))
            {

                ThrowingHoldButton(); // Pour tester sur PC

            }


            else if (Input.GetKeyUp(actionKey))
            {

                ThrowingUpButton(); // Rien à voir avec le vomi
            }


            if (strength > 10f)
            {
                strength = 10f;

            }


            scrollbar.size = strength / strengthMax;

        }

        public void ThrowingHoldButton()
        {

            if (isThrowing == false && strength < 10f)
            {

                strength += 0.01f;

            }


        }

        public void ThrowingUpButton()
        {

            rb.AddForce(transform.right * strength, ForceMode2D.Impulse); // Applique une certaine force vers la droite
            rb.AddForce(transform.up * strength, ForceMode2D.Impulse); // Applique une certaine force vers le haut
            isThrowing = true;


        }


    }

}

  

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace SebastienMiniGame1
{
    public class BallInteraction : MonoBehaviour
    {
        public KeyCode mainKey;
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
            // Strength maximum (capée pour ne pas envoyer la balle trop loin) = 8

            if (Input.GetKey(mainKey) && isThrowing == false && strength < 10f)
            {

                strength += 0.1f;


            }

            else if (Input.GetKey(mainKey) && isThrowing == false && strength >= 10f)
            {

                strength -= 0.1f;


            }



            else if (Input.GetKeyUp(mainKey) && isThrowing == false)
            {

                rb.AddForce(transform.right * strength, ForceMode2D.Impulse);
                rb.AddForce(transform.up * strength, ForceMode2D.Impulse);
                isThrowing = true;

            }


            if (strength > 10f)
            {
                strength = 10f;

            }



            scrollbar.size = strength / strengthMax;



        }


    }

}

  

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CorentinB_Game1
{

    public class Game1_Action : MonoBehaviour
    {
        public GameObject Fusee;

        public void OnCollisionEnter2D(Collision2D collision)
        {

            if (collision.transform.gameObject.tag == "Box")
            {
                //ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
                print("t'es mort");
            }

            if (collision.transform.gameObject.tag == "Finish")
            {
                //ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
                print("victoire");
            }
        }
    }
}
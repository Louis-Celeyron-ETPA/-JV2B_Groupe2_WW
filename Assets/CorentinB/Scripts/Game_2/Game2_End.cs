using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CorentinB_Game2
{
    public class Game2_End : MonoBehaviour
    {
        public GameObject Perso;
        public void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.transform.gameObject.tag == "Finish")
            {
                //ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
                Perso.GetComponent<Renderer>().enabled = false;
            }
        }
    }
}

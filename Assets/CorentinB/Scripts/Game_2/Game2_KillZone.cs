using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CorentinB_Game2 {

public class Game2_KillZone : MonoBehaviour
{
    public GameObject Perso;

    void Update()
    {
        transform.position += new Vector3(0.00080f, 0);
    }

        private void OnTriggerEnter2D(Collider2D collision)
    {
            //ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            print("t'es mort");
    }
    }
}
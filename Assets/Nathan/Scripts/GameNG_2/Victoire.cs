using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NatanG_minijeu2
{

    public class Victoire : MonoBehaviour
    {

        public GameObject Perso;

        //------------------------------------- arriver dans la zone fait gagner
        private void OnTriggerEnter2D(Collider2D collision)
        {
            
            ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
        }
    }
}

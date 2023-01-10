using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NatanG_minijeu2
{
    public class defaite : MonoBehaviour
    {
        public GameObject Perso;

        void Update()
        {
            //------------------------------------- La zone avance
            transform.position += new Vector3(0.0035f, 0);
        }
        //------------------------------------- Les zone tue le joueur
        private void OnTriggerEnter2D(Collider2D collision)
        {
            //ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            Destroy(Perso);
        }
    }
}

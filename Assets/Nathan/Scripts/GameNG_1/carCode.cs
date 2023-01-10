using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NatanG_minijeu1
{
    public class carCode : MonoBehaviour
    {
        public Transform Plane;

        void Update()
        {
            //------------------------------------- Déplacement avec la voiture du joueur
            if (Input.GetKeyDown(KeyCode.UpArrow) && gameObject.transform.position.y < 2)
            {
                gameObject.transform.Translate(Vector3.left * 1.6f);
            }

            if (Input.GetKeyDown(KeyCode.DownArrow) && gameObject.transform.position.y > 0)
            {
                gameObject.transform.Translate(Vector3.right * 1.6f);
            }

        }
        //défaite du joueur
        private void OnTriggerEnter2D(Collider2D collision)
        {
            //ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            Destroy(gameObject);
        }

    }
}

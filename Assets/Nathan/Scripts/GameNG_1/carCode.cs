using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NatanG_minijeu1
{
    public class CarCode : MonoBehaviour
    {
        public bool horizontalAxisUsed;

        //défaite du joueur
        private void OnTriggerEnter2D(Collider2D collision)
        {
            //ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            Destroy(gameObject);
        }

        public void MoveCarUp() // voiture va sur la ligne du haut
        {
            if (!horizontalAxisUsed) // = if(isUpDown == false)
            {
                if (gameObject.transform.position.y < 2)
                {
                    horizontalAxisUsed = true;
                    gameObject.transform.Translate(Vector3.left * 1.6f);
                }
            }
        }

            public void MoveCarDown() // voiture va sur la ligne du bas
        {
                if (!horizontalAxisUsed) // = if(isUpDown == false)
                {
                    if (gameObject.transform.position.y > 0)
                    {
                        horizontalAxisUsed = true;
                        gameObject.transform.Translate(Vector3.right * 1.6f );
                    }
                }
            }

            public void Reset() // reset de horizontalAxisUsed
        {
            horizontalAxisUsed = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SebastienMiniGame1
{
    public class Victory : MonoBehaviour
    {
        private bool _victory = false;

        public void Update()
        {
            if (_victory)
            {
               ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
               _victory = false; // Reset la var victory pour empêcher la boucle.

            }

        }
        public void OnCollisionEnter2D(Collision2D collisionGoal)
        {
            if (collisionGoal.transform.gameObject.name == "Ball")
            {
                collisionGoal.gameObject.SetActive(false);
                Debug.Log("GG");
                _victory = true;
            }
        }
    }
}

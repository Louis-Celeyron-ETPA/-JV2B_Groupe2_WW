using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HARDYCorentin
{
    public class Ennemy_behavior : MonoBehaviour
    {
        public GameObject ennemy;
        public float moveleft = -0.01f;
        public float moveright = 0.01f;
        public float stayput = 0f;
        public Difficulty df;
        public int loseCondition = 0;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {

            transform.position = Vector3.MoveTowards(transform.position, Vector3.zero, moveright);
            if(transform.position == Vector3.zero)
            {
                loseCondition = loseCondition + 1;
                Destroy(gameObject);
            }
            if (loseCondition >= 6 / df.GetDifficulty())
            {
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            }

        }
        private void OnCollisionEnter(Collision collision)
        {
            Destroy(gameObject);
        }
    }
}


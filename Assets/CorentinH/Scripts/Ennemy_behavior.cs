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
        public float difficulty = 1f;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {

            
            
            if (ennemy.transform.position.x < 0)
            {
                transform.position =/* Camera.main.ScreenToWorldPoint(*/new Vector3(ennemy.transform.position.x + moveright*difficulty, 0f)/*)*/;
                Debug.Log("A");
            }
            if (ennemy.transform.position.y < 0)
            {
                transform.position =/* Camera.main.ScreenToWorldPoint(*/new Vector3(ennemy.transform.position.y + moveright * difficulty, 0f)/*)*/;
                Debug.Log("A");
            }
            else if (ennemy.transform.position.x > 0)
            {
                transform.position = new Vector3(ennemy.transform.position.x + moveleft * difficulty, 0f);
                Debug.Log("B");
            }

            else if (ennemy.transform.position.y > 0)
            {
                transform.position = new Vector3(ennemy.transform.position.y + moveleft * difficulty, 0f);
                
            }

            if (ennemy.transform.position.x == 0 & ennemy.transform.position.y == 0)
                {
                    transform.position =new Vector3(ennemy.transform.position.x + stayput, ennemy.transform.position.y + stayput, 0f);
                    ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);  
                    Debug.Log("You lost.");

                }
            }

        }
   }


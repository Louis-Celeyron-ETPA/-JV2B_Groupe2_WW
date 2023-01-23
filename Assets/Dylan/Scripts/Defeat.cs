using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Dylan
{
    public class Defeat : MonoBehaviour

    {
        public GameObject Cube;
        public float minTime, maxTime;
        public float currentTime;
        public int countDownDefeat = 0;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        public float timeRemaining = 15;
        void Update()

        {

            if (timeRemaining > 0)

            {
                currentTime = Random.Range(minTime, maxTime);

                timeRemaining -= Time.deltaTime;

            }
            if (timeRemaining <= 0)
            {
                Debug.Log("J'EXPLOSE A L'AIDE");
                countDownDefeat = countDownDefeat + 1;
                Destroy(Cube.transform.gameObject);
                
            }
            if(countDownDefeat >= 2)
            {
                Debug.Log("T'AS PERDU HAHAHAH");
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            }

        }
    }
}
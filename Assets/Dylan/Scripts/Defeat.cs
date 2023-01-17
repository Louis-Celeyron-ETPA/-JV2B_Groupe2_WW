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
                Destroy(Cube.transform.gameObject);
            }
        }
    }
}
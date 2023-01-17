using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Dylan
{
    public class Spawner : MonoBehaviour
    {
        private float spawnPositionZ = 0.01f;
        public GameObject objectToSpawn;
        public Transform parent;
        public GameObject Rouge;
        public GameObject Bleu;

        public float minTime, maxTime;
        public float currentTime;
        // Start is called before the first frame update

        void Update()
        {
            currentTime -= Time.deltaTime;
            if (currentTime <= 0)
            {
                Instantiate(objectToSpawn, parent);
                currentTime = Random.Range(minTime, maxTime);
            }


        }
    }
}


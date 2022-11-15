using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Dylan
{
    public class Spawner : MonoBehaviour
    {
        public float spawnPositionZ = 0.001f;
        public GameObject objectToSpawn;
        public Transform parent;
        public GameObject Rouge;
        public GameObject Bleu;

        public float minTime, maxTime;
        public float currentTime;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
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

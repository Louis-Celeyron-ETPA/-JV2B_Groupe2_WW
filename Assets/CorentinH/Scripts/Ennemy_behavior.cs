using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HARDYCorentin
{
    public class Ennemy_Behavior : MonoBehaviour
    {
        public GameObject ennemy;
        public float moveleft = -0.01f;
        public float moveright = 0.01f;
        public float stayput = 0f;
        public float difficulty = 1f;
        public int loseCondition = 0;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {

            transform.position = Vector3.MoveTowards(transform.position, Vector3.zero, moveright);

        }
        private void OnCollisionEnter(Collision collision)
        {
            Destroy(gameObject);
        }
    }
}


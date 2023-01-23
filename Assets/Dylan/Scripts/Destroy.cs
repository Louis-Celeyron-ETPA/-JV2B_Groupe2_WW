using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Dylan
{
    public class Destroy : MonoBehaviour
    {
        public Defeat lose;
        public GameObject Cube;

        // Start is called before the first frame update
        void Start()
        {

        }
        
        // Update is called once per frame
        void Update()
        {
            if (lose.timeRemaining >= 0)
            {
                Destroy(Cube.transform.gameObject);
            }
        }
    }
}
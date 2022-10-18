using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HARDYCorentin
{
    public class Ennemy_behavior : MonoBehaviour
    {
        public GameObject ennemy;
        public float Moveleft = -0.0001f;
        public float Moveright = 0.0001f;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (0 > ennemy.transform.position.x)
            {
                transform.position = Camera.main.ScreenToWorldPoint(new Vector3(ennemy.transform.position.x + Moveright, 200, Camera.main.farClipPlane));
            }
            else if (ennemy.transform.position.x > 0)
            {
                transform.position = Camera.main.ScreenToWorldPoint(new Vector3(ennemy.transform.position.x + Moveleft, 200, Camera.main.farClipPlane));
            }
            else if (ennemy.transform.position.x == 0)
            {
                return;
            }
        }
    }
}

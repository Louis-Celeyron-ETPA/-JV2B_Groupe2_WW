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
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            /*if (Camera.main.WorldToScreenPoint(ennemy.transform.position).x < Camera.main.pixelWidth/2)
            {
                transform.position = Camera.main.ScreenToWorldPoint(new Vector3(ennemy.transform.position.x + Moveright, 200, Camera.main.farClipPlane))*-1;
                Debug.Log("A");
            }
            else if (Camera.main.WorldToScreenPoint(ennemy.transform.position).x > Camera.main.pixelWidth / 2)
            {
                transform.position = Camera.main.ScreenToWorldPoint(new Vector3(ennemy.transform.position.x + Moveleft, 200, Camera.main.farClipPlane))*-1;
                Debug.Log("B");
            }
            else if (Camera.main.WorldToScreenPoint(ennemy.transform.position).x == Camera.main.pixelWidth / 2)
            {
                transform.position = Camera.main.ScreenToWorldPoint(new Vector3(ennemy.transform.position.x + Stayput, 200, Camera.main.farClipPlane))*-1;
            }*/
            if (ennemy.transform.position.x < 0)
            {
                transform.position =/* Camera.main.ScreenToWorldPoint(*/new Vector3(ennemy.transform.position.x + moveright, 0, 57.9f)/*)*/;
                Debug.Log("A");
            }
            if (ennemy.transform.position.x > 0)
            {
                transform.position =/* Camera.main.ScreenToWorldPoint(*/new Vector3(ennemy.transform.position.x + moveleft, 0, 57.9f)/*)*/;
                Debug.Log("B");

                if (ennemy.transform.position.x == 0)
                {
                    transform.position =/* Camera.main.ScreenToWorldPoint(*/new Vector3(ennemy.transform.position.x + stayput, 0, 57.9f)/*)*/;
                    Debug.Log("C");
                }
            }
        }
    }
}

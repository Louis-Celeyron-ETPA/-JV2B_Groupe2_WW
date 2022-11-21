using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace HARDYCorentin{
    public class Temp_Input_CorentinH : MonoBehaviour
    {
        public GameObject player;
        public float playermoveleft = -0.04f;
        public float playermoveright = 0.04f;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position = new Vector3(player.transform.position.x + playermoveleft, 0f);
                Debug.Log("A");
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position = new Vector3(player.transform.position.x + playermoveright, /*Camera.main.farClipPlane*/ 0f);
                Debug.Log("B");
            }
            //else if ()
        } 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Dylan
{

    public class DragAndDrop : MonoBehaviour
    {
        public GameObject cube ;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetKey(KeyCode.Space))
            {
                if (Physics.BoxCast(cube.transform.position, Vector3.one/2, Vector3.forward/2, out var objectHitted))
                {
                    if(objectHitted.collider.tag =="Cube")
                    {
                        objectHitted.transform.position = new Vector3(cube.transform.position.x, cube.transform.position.y , objectHitted.transform.position.z);
                    }
                }

            }

        }

    }
}

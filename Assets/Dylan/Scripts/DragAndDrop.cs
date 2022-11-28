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
            if(Physics.Raycast(Vector3.zero,Vector3.back))
            Debug.DrawRay(cube.transform.position, Vector3.back * 8000);
        }
       
    }
}

    using System.Collections;
using System.Collections.Generic;

using UnityEngine;
namespace Dylan
{

    public class Zone : MonoBehaviour

    {
        public GameObject Cube;
        public GameObject Safe;
        private Color boxColor = Color.cyan;

        public string nameToCheck;
        // Start is called before the first frame update
        void Start()
        {

        }
        // Update is called once per frame
        void Update()
        {
        }

        private void OnTriggerEnter(Collider other)
        {

            if (other.gameObject.name.Contains(nameToCheck))
            {
                Destroy(other.gameObject);
            }
        }
    }
}

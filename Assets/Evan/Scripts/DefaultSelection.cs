using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


namespace Evan
{ 
    public class DefaultSelection : MonoBehaviour
    {
        public EventSystem system;
        public GameObject toSelect;
        // Start is called before the first frame update
        void Start()
        {
            system.SetSelectedGameObject(toSelect);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
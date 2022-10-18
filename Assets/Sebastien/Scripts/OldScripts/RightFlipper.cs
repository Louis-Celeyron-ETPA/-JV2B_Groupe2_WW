using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightFlipper : MonoBehaviour { 

    public KeyCode rightKey;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(rightKey))
        {
            GetComponent<Transform>().eulerAngles = new Vector3(-29, -22, 0);

        }

        else if (Input.GetKeyUp(rightKey))
        {
            GetComponent<Transform>().eulerAngles = new Vector3(35, 42, 15);

        }

    }
}

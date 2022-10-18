using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftFlipper : MonoBehaviour { 

    public KeyCode leftKey;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(leftKey))
        {
            GetComponent<Transform>().eulerAngles = new Vector3(29, 22, 0);
       

        }


        else if (Input.GetKeyUp(leftKey))
        {
            GetComponent<Transform>().eulerAngles = new Vector3(-42, -31, 0);

        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPosition : MonoBehaviour
{
    //public Vector3 initialPosition;
    public Transform Position;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Position.position = Position.position + new Vector3(0f, 0.5f, 0f);
            GetComponent<Rigidbody2D>().AddForce(new Vector2 (0,150f),ForceMode2D.Force);
        }

        
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouv : MonoBehaviour
{
    public KeyCode maTouche;
    public KeyCode maTouche2;
    public Transform Position;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(maTouche))
        {
            Position.position = Position.position + new Vector3(0.1f, 0f, 0f);

        }
        if (Input.GetKey(maTouche2))
        {
            Position.position = Position.position + new Vector3(-0.1f, 0f, 0f);

        }
    }
}

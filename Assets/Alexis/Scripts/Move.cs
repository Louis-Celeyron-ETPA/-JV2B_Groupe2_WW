using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public bool switchBool = false;
    // Start is called before the first frame update
    void Start()
    {
        //Invoke("SwitchControl", 1.0f); //à changer
    }

    // Update is called once per frame
    void Update()
    {
        while (switchBool==false)
        {
        if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position = new Vector3(transform.position.x - 0.01f , 0f, transform.position.z);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position = new Vector3(transform.position.x + 0.01f, 0f, transform.position.z);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position = new Vector3(transform.position.x, 0f, transform.position.z + 0.01f);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.position = new Vector3(transform.position.x, 0f, transform.position.z - 0.01f);
            }
        }
    }

    public void MoveAgHaut()
    {
        if (switchBool==false)
        {
            transform.position = new Vector3(transform.position.x, 0f, transform.position.z + 0.01f);
        }
    }

    public void MoveAgBas()
    {
        if (switchBool==false)
        {
            transform.position = new Vector3(transform.position.x, 0f, transform.position.z - 0.01f);
        }
    }

    public void MoveAgGauche()
    {
        if (switchBool==false)
        {
            transform.position = new Vector3(transform.position.x - 0.01f , 0f, transform.position.z);
        }
    }

    public void MoveAgDroite()
    {
        if (switchBool==false)
        {
            transform.position = new Vector3(transform.position.x + 0.01f, 0f, transform.position.z);
        }
    }

    //passe du contrôle de l'agitateur à la sélection de réponse
    void SwitchControl()
    {
        switchBool = true;
    }
}

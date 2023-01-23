using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public bool switchBool = false;
    private float _decompte = 1f;//à changer

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (_decompte > 0)
            {
                _decompte -= Time.deltaTime;
            }
            else
            {
                //passe du contrôle de l'agitateur à la sélection de réponse
                switchBool = true;
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (!switchBool)
                {
                    transform.position = new Vector3(transform.position.x - 0.01f, 0f, transform.position.z);
                }
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                if (!switchBool)
                {
                    transform.position = new Vector3(transform.position.x + 0.01f, 0f, transform.position.z);
                }
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                if (!switchBool)
                {
                    transform.position = new Vector3(transform.position.x, 0f, transform.position.z + 0.01f);
                }
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                if (!switchBool)
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


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionPerso : MonoBehaviour
{
    public GameObject Perso;
    // Start is called before the first frame update
    public void OnCollisionEnter2D(Collision2D collision)
    { 

        if (collision.transform.gameObject.tag == "Finish")
        {
            Perso.transform.position = new Vector3(-24.4f,39.2f, -0.15f);
        }
    }
}

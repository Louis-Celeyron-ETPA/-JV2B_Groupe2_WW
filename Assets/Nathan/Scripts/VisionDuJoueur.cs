using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionDuJoueur : MonoBehaviour
{
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        gameObject.GetComponent<Renderer>().enabled = true;
    }
}

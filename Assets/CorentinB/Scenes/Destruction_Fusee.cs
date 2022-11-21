using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction_Fusee : MonoBehaviour
{
    public GameObject Fusee;
    // Start is called before the first frame update
    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.transform.gameObject.tag == "Box")
        {
            Fusee.transform.position = new Vector3(0, -5.5f, 0.12f);
        }

        if (collision.transform.gameObject.tag == "Finish")
        {
            Fusee.transform.position = new Vector3(0, 57.7f, -0.07f);
        }



    }
}

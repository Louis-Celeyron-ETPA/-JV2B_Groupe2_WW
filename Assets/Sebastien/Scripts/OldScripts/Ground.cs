using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour

{

    public Items varScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.gameObject.name == "cake(Clone)")
        {
            collision.gameObject.SetActive(false);
            Debug.Log("Oups");
            varScore.score -= 1;


        }

        else if (collision.transform.gameObject.name == "bomb(Clone)")
        {
            collision.gameObject.SetActive(false);
            Debug.Log("C'�tait moins une");
        }


    }
}

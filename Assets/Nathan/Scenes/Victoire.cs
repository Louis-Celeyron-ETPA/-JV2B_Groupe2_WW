using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victoire : MonoBehaviour
{

    public GameObject Perso;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("box box");
        Perso.transform.position = new Vector3(7,0);
    }
}

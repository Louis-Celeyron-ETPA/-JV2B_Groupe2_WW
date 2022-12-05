using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defaite : MonoBehaviour
{
    public GameObject Perso;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0.0035f, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("t mort");
        Destroy(Perso);
    }
}

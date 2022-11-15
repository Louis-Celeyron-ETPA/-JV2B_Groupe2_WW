using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrowningPerson : MonoBehaviour
{
    public GameObject goal;
    // Start is called before the first frame update
    void Start()
    {
       
        goal.transform.position = new Vector2(Random.Range(-5, 8), -4.5f);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

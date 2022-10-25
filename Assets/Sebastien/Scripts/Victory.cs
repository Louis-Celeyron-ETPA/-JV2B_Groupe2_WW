using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    public bool victory = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collisionGoal)
    {
        if (collisionGoal.transform.gameObject.name == "Ball")
        {
            collisionGoal.gameObject.SetActive(false);
            Debug.Log("GG");
            victory = true;

        }
    }
}

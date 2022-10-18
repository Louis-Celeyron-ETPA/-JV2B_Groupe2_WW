using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoredCollision : MonoBehaviour
{
    
    public MeshRenderer MR;
    public Color meshColor = Color.blue;

    private void OnCollisionEnter(Collision collision)
    {

        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);

        Color tempColor = new Color(r, g, b);
        MR.material.color = tempColor;
        Points.instance.AddPoints();

        //collision.contacts[0].normal

    }
    // Start is called before the first frame update
    void Start()

    {
       
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    void Awake()
    {


    }
}

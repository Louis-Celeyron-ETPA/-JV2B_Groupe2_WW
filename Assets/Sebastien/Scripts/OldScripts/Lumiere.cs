using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lumiere : MonoBehaviour
{
    // Start is called before the first frame update

    public Light cycle;
    public Color colorStart = Color.cyan;
    public Color colorEnd = Color.red;

    public float percentage = 0.02f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        cycle.color = Color.Lerp(colorStart, colorEnd, percentage);
        percentage += 0.0001f;

       
   
        
    }
}


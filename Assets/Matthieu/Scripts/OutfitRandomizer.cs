using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitRandomizer : MonoBehaviour
{
    public Sprite[] headParts;
    public Sprite[] bodyParts;
    public GameObject headDisplay, bodyDisplay; 
    

    // Start is called before the first frame update
    void Start()
    {
        
        Sprite randomHead = headParts[Random.Range(0, headParts.Length)]; 
        Sprite randomBody = bodyParts[Random.Range(0, bodyParts.Length)];

        headDisplay.GetComponent<SpriteRenderer>().sprite = randomHead;
        bodyDisplay.GetComponent<SpriteRenderer>().sprite = randomBody;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

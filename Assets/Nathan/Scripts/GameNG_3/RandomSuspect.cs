using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSuspect : MonoBehaviour
{
    public selection placementSelec;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(placementSelec.placementSelection);
    }
}

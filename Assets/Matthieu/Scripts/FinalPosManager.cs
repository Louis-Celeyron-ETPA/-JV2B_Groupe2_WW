using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPosManager : MonoBehaviour
{
    // Start is called before the first frame update

    public List<Vector3> positions;
    public List<Vector3> finalPositions; 
    void Start()
    {
        finalPositions = new List<Vector3>(); 
        for (int i = 0; i < 3; i++)
        {
            int index = Random.Range(0, positions.Count); 
            finalPositions.Add(positions[index]);
            positions.RemoveAt(index); 
        }

        Debug.Log(finalPositions[0]); 
        Debug.Log(finalPositions[1]); 
        Debug.Log(finalPositions[2]); 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

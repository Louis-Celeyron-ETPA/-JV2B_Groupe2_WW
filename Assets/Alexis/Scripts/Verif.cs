using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verif : MonoBehaviour
{
    public List<GameObject> listeBoules;
    public int totalOrange;
    public int totalVert;
    public int valeur;

    void Start()
    {
        for (int i = 0; i < 9; i++)
        {
            var currentcolor = listeBoules[i].GetComponent<Mat>().numcol;
            if (currentcolor == 1)
            {
                totalVert = totalVert + 1;
            }
            Debug.Log(currentcolor);
        }
        Debug.Log(totalVert);
    }
}

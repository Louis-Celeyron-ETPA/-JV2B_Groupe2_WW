using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verif : MonoBehaviour
{
    public List<GameObject> Listeboules;
    public int totalorange;
    public int totalvert;
    public int valeur;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 9; i++)
        {
            var currentcolor = Listeboules[i].GetComponent<Mat>().numcol;
            if (currentcolor == 1)
            {
                totalvert = totalvert + 1;
            }
            Debug.Log(currentcolor);
        }
        Debug.Log(totalvert);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Un()
    {
        if (totalvert == 1)
        {
            Debug.Log("gagné");
        }
    }
    void Deux()
    {
        if (totalvert == 1)
        {
            Debug.Log("gagné");
        }
    }
    void Trois()
    {
        if (totalvert == 1)
        {
            Debug.Log("gagné");
        }
    }
    void Quatre()
    {
        if (totalvert == 1)
        {
            Debug.Log("gagné");
        }
    }
    void Cinq()
    {
        if (totalvert == 1)
        {
            Debug.Log("gagné");
        }
    }
    void Six()
    {
        if (totalvert == 1)
        {
            Debug.Log("gagné");
        }
    }
    void Sept()
    {
        if (totalvert == 1)
        {
            Debug.Log("gagné");
        }
    }
    void Huit()
    {
        if (totalvert == 1)
        {
            Debug.Log("gagné");
        }
    }
    void Neuf()
    {
        if (totalvert == 1)
        {
            Debug.Log("gagné");
        }
    }
    void Zero()
    {
        if (totalvert == 1)
        {
            Debug.Log("gagné");
        }
    }

}

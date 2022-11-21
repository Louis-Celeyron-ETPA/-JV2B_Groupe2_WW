using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verif : MonoBehaviour
{
    public List<GameObject> Listeboules;
    public int totalorange;
    public int totalvert;
    public int valeurentree;
    // Start is called before the first frame update
    void Start()
    {
        foreach (var mat in FindObjectsOfType<Mat>())
        {
            if (mat.numcol == 1 )
            {
                totalvert = totalvert + 1;
            }
            if (mat.numcol == 2)
            {
                totalvert = totalorange + 1;
            }
        }
        Debug.Log(totalvert);
    }

    // Update is called once per frame
    void Update()
    {
    }
}

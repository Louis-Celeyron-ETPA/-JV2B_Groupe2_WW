using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mat : MonoBehaviour
{
    private Color couleurboule1 = new Color(26, 212, 0);
    private Color couleurboule2 = new Color(226, 118, 0);
    public MeshRenderer mr;
    public int numcol = 0;
    // Start is called before the first frame update
    void Awake()
    {
        /*numcol = Random.Range(1, 3);
        if (numcol==1)
        {
            mr.material.color = Color.green;
        }
        if (numcol == 2)
        {
            mr.material.color = couleurboule2;
        }*/

    }
}

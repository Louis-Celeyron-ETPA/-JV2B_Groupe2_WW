using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mat : MonoBehaviour
{
    private Color _couleurboule1 = new Color(26, 212, 0);
    private Color _couleurboule2 = new Color(226, 118, 0);
    public MeshRenderer mr;
    public int numCol = 0;
    // Start is called before the first frame update
    void Awake()
    {
        numCol = Random.Range(1, 3);
        if (numCol==1)
        {
            mr.material.color = Color.green;
        }
        if (numCol == 2)
        {
            mr.material.color = _couleurboule2;
        }

    }
}

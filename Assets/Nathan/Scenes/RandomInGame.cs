using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomInGame : MonoBehaviour
{
    public GameObject Perso;
    public GameObject mur1_1;
    public GameObject mur1_2;
    public GameObject mur1_3;
    public GameObject mur2_1;
    public GameObject mur2_2;
    public GameObject mur2_3;


    // Start is called before the first frame update
    void Start()
    {
        int randomPositon = Random.Range(-1, 4);
        Perso.transform.position = new Vector3(-2, randomPositon);

        int porte_1 = Random.Range(1, 4);
        if (porte_1 == 1)
        {
            Destroy(mur1_1);
        }
        else if (porte_1 == 2)
        {
            Destroy(mur1_2);
        }
        else if (porte_1 == 3)
        {
            Destroy(mur1_3);
        }

        int porte_2 = Random.Range(1, 4);
        if (porte_2 == 1)
        {
            Destroy(mur2_1);
        }
        else if (porte_2 == 2)
        {
            Destroy(mur2_2);
        }
        else if (porte_2 == 3)
        {
            Destroy(mur2_3);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

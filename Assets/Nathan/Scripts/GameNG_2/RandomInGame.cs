using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NatanG_minijeu2
{

    public class RandomInGame : MonoBehaviour
{

    public GameObject Perso;
    public GameObject Sortie;
    //------------------------------------- les murs random
    public GameObject mur1_1;
    public GameObject mur1_2;
    public GameObject mur1_3;
    public GameObject mur2_1;
    public GameObject mur2_2;
    public GameObject mur2_3;


    void Start()
    {
        //------------------------------------- Random du perso
        int randomPositon = Random.Range(1, 4);
        if (randomPositon == 1)
        {
            Perso.transform.position = new Vector3(-2, 4.35f);
        }
        else if (randomPositon == 2)
        {
            Perso.transform.position = new Vector3(-2, 1.5f);
        }
        else if (randomPositon == 3)
        {
            Perso.transform.position = new Vector3(-2, -0.7f);
        }

        //------------------------------------- Random des murs 1
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

        //------------------------------------- Random des murs 2
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

        //------------------------------------- Random de la sortie
        int randomPositonS = Random.Range(1, 4);
        if (randomPositonS == 1)
        {
            Sortie.transform.position = new Vector3(5, 4.35f);
        }
        else if (randomPositonS == 2)
        {
            Sortie.transform.position = new Vector3(5, 1.5f);
        }
        else if (randomPositonS == 3)
        {
            Sortie.transform.position = new Vector3(5, -0.7f);
        }

    }
}
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBouton : MonoBehaviour
{
    public GameObject referenceBouton;
    public int valeur;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void verification()
    {
        if (referenceBouton.GetComponent<Verif>().totalvert == valeur)
        {
            Debug.Log("gagné");
        }
    }
}

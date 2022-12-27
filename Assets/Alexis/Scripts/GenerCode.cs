using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GenerCode : MonoBehaviour
{
    public int touche;
    public string nomTouche;
    public List<int> combiBase = new List<int>();
    public List<int> combiRepro = new List<int>();
    public TextMeshProUGUI texte1;
    public TextMeshProUGUI texte2;
    public TextMeshProUGUI texte3;
    private int indexCombi = 0;
    public GameObject canva;
    private bool valide = false;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            touche = Random.Range(1, 4);
            combiBase.Add(touche);
            if (touche==1)
            {
                nomTouche = "Haut";
            }
            if (touche == 2)
            {
                nomTouche = "Droite";
            }
            if (touche == 3)
            {
                nomTouche = "Bas";
            }
            if (touche == 4)
            {
                nomTouche = "Gauche";
            }
            if (i==0)
            {
                texte1.text= nomTouche;
            }
            if (i == 1)
            {
                texte2.text = nomTouche;
            }
            if (i == 2)
            {
                texte3.text = nomTouche;
            }
        }
        print(combiBase);
    }

    // Update is called once per frame
    void Update()
    {
        if (valide==true)
        {
            if (Input.GetKeyDown(KeyCode.Z))
        {
            CombiHaut();
        }
        

       if (Input.GetKeyDown(KeyCode.Q))
        {
            CombiGauche();
        }
        
        
        if (Input.GetKeyDown(KeyCode.S))
        {
             CombiBas();
        }
        

        if (Input.GetKeyDown(KeyCode.D))
        {
            CombiDroite();
        }
        }
        
            
        if (Input.GetKeyDown(KeyCode.Space))
        {
            canva.SetActive(false);
            valide = true;
        }
       if (indexCombi >= 3){
        Debug.Log("Gagne");
       }
    }
    
    void CombiHaut()
    {
        if (valide==true){
        combiRepro.Add(1);
        if (combiBase[indexCombi] == combiRepro[indexCombi])
        {
            Debug.Log("Bien");
            indexCombi = indexCombi + 1;
        }
        }
    }

    void CombiDroite()
    {
        if (valide==true){
        combiRepro.Add(2);
        if (combiBase[indexCombi] == combiRepro[indexCombi])
        {
            Debug.Log("Bien");
            indexCombi = indexCombi + 1;
        }
        }
    }
    void CombiBas()
    {
        if (valide==true){
        combiRepro.Add(3);
        if (combiBase[indexCombi] == combiRepro[indexCombi])
        {
            Debug.Log("Bien");
            indexCombi = indexCombi + 1;
        }
        }
    }
    void CombiGauche()
    {
        if (valide==true){
        combiRepro.Add(4);
        if (combiBase[indexCombi] == combiRepro[indexCombi])
        {
            Debug.Log("Bien");
            indexCombi = indexCombi + 1;
        }
        }
    }
    void Action()
    {
        canva.SetActive(false);
            valide = true;
    }
}


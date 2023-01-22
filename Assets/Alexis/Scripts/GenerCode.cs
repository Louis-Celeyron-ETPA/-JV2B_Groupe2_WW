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
    public List<TextMeshProUGUI> listeTexte = new List<TextMeshProUGUI>();
    public List<GameObject> listeImage = new List<GameObject>();
    public Material matCheck;

    private int indexCombi = 0;
    public GameObject canva;
    private bool valide = false;
    private int dif = 5;

    // Start is called before the first frame update
    void Start()
    {
        //if (ManagerManager.DifficultyManager.GetDifficulty() = 0)
        for (int i = 0; i < 7; i++)
        {
            listeTexte[i].alpha = 0;
            listeImage[i].SetActive(false);
        }
        for (int i = 0; i < dif; i++)
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
            listeTexte[i].alpha = 1;
            listeImage[i].SetActive(true);
            listeTexte[i].text = nomTouche;
        }
        print(combiBase);
    }

    // Update is called once per frame
    void Update()
    {
        //controles pc
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
       if (indexCombi >= dif){
        Debug.Log("Gagne");
        ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
       }
    }
    
//a chaque fois qu'on active une de ces fonctions, elle ajoute l'input à la liste et la compare avec l'originale

    public void CombiHaut()
    {
        if (valide==true){
        combiRepro.Add(1);
        if (combiBase[indexCombi] == combiRepro[indexCombi])
        {
            Debug.Log("Bien");
            listeImage[indexCombi].GetComponent<MeshRenderer>().material = matCheck;
            indexCombi = indexCombi + 1;
        }
        else
        {
          ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);  
        }
        }
    }

    public void CombiDroite()
    {
        if (valide==true){
        combiRepro.Add(2);
        if (combiBase[indexCombi] == combiRepro[indexCombi])
        {
            Debug.Log("Bien");
            listeImage[indexCombi].GetComponent<MeshRenderer>().material = matCheck;
            indexCombi = indexCombi + 1;
        }
        else
        {
          ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);  
        }
        }
    }
    public void CombiBas()
    {
        if (valide==true){
        combiRepro.Add(3);
        if (combiBase[indexCombi] == combiRepro[indexCombi])
        {
            Debug.Log("Bien");
            listeImage[indexCombi].GetComponent<MeshRenderer>().material = matCheck;
            indexCombi = indexCombi + 1;
        }
        else
        {
          ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);  
        }
        }
    }
    public void CombiGauche()
    {
        if (valide==true){
        combiRepro.Add(4);
        if (combiBase[indexCombi] == combiRepro[indexCombi])
        {
            Debug.Log("Bien");
            listeImage[indexCombi].GetComponent<MeshRenderer>().material = matCheck;
            indexCombi = indexCombi + 1;
        }
        else
        {
          ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);  
        }
        }
    }

    //valide qu'on a vu le code et permet de passer en mode saisie
    public void Action()
    {
        canva.SetActive(false);
            valide = true;
    }
}


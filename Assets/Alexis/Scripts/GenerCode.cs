using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Alexis
{

public class GenerCode : MonoBehaviour
{
    public int touche;
    public string nomTouche;
    public List<int> combiBase = new List<int>();
    public List<int> combiRepro = new List<int>();
    public List<TextMeshProUGUI> listeTexte = new List<TextMeshProUGUI>();
    public List<GameObject> listeImage = new List<GameObject>();
    public Material matCheck;

    private int _indexCombi = 0;
    public GameObject _canva;
    private bool _valide = false;
    private int _dif = 5;

    void Start()
    {
        //Plus c'est dur, plus la combinaison est longue
        if (ManagerManager.DifficultyManager.GetDifficulty() == 1)
        {
            _dif = 3;
        }

        if (ManagerManager.DifficultyManager.GetDifficulty() == 2)
        {
            _dif = 5;
        }

        if (ManagerManager.DifficultyManager.GetDifficulty() == 3)
        {
            _dif = 7;
        }


        for (int i = 0; i < 7; i++)
        {
            listeTexte[i].alpha = 0;
            listeImage[i].SetActive(false);
        }
        for (int i = 0; i < _dif; i++)
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
        if (_valide==true)
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
            _canva.SetActive(false);
            _valide = true;
        }
       if (_indexCombi >= _dif){
        Debug.Log("Gagne");
        ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
       }
    }
    
//a chaque fois qu'on active une de ces fonctions, elle ajoute l'input à la liste et la compare avec l'originale

    public void CombiHaut()
    {
        if (_valide==true){
        combiRepro.Add(1);
        if (combiBase[_indexCombi] == combiRepro[_indexCombi])
        {
            Debug.Log("Bien");
            listeImage[_indexCombi].GetComponent<MeshRenderer>().material = matCheck;
            _indexCombi = _indexCombi + 1;
        }
        else
        {
          ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);  
        }
        }
    }

    public void CombiDroite()
    {
        if (_valide==true){
        combiRepro.Add(2);
        if (combiBase[_indexCombi] == combiRepro[_indexCombi])
        {
            Debug.Log("Bien");
            listeImage[_indexCombi].GetComponent<MeshRenderer>().material = matCheck;
            _indexCombi = _indexCombi + 1;
        }
        else
        {
          ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);  
        }
        }
    }
    public void CombiBas()
    {
        if (_valide==true){
        combiRepro.Add(3);
        if (combiBase[_indexCombi] == combiRepro[_indexCombi])
        {
            Debug.Log("Bien");
            listeImage[_indexCombi].GetComponent<MeshRenderer>().material = matCheck;
            _indexCombi = _indexCombi + 1;
        }
        else
        {
          ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);  
        }
        }
    }
    public void CombiGauche()
    {
        if (_valide==true){
        combiRepro.Add(4);
        if (combiBase[_indexCombi] == combiRepro[_indexCombi])
        {
            Debug.Log("Bien");
            listeImage[_indexCombi].GetComponent<MeshRenderer>().material = matCheck;
            _indexCombi = _indexCombi + 1;
        }
        else
        {
          ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);  
        }
        }
    }

    //_valide qu'on a vu le code et permet de passer en mode saisie
    public void Action()
    {
        _canva.SetActive(false);
            _valide = true;
    }
}
}


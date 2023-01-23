using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MOVEMJ3 : MonoBehaviour
{
    private int _nombre = 0;
    public GameObject refBool;
    public TextMeshProUGUI texteNombre;
    private string _nombreVersTexte;
    public List<TextMeshProUGUI> listeTexteCache = new List<TextMeshProUGUI>();
    public List<GameObject> listeObjetsCache = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 2; i++){
        listeTexteCache[i].alpha = 0;
        listeObjetsCache[i].SetActive(false);
        }
        listeObjetsCache[2].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (refBool.GetComponent<Move>().switchBool==true)
        {
            for (int i = 0; i < 2; i++){
            listeTexteCache[i].alpha = 1;
            listeObjetsCache[i].SetActive(true);
            }
            listeObjetsCache[2].SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            NombreMoins();
        }
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            NombrePlus();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ValideNombre();
        }
    }

    void NombrePlus()
    {
        if (refBool.GetComponent<Move>().switchBool==true){
            _nombre = _nombre + 1;
            _nombreVersTexte =_nombre.ToString();
            texteNombre.text = _nombreVersTexte;
        }
    }

    void NombreMoins()
    {
        if (refBool.GetComponent<Move>().switchBool==true){
            _nombre = _nombre - 1;
            _nombreVersTexte = _nombre.ToString();
            texteNombre.text = _nombreVersTexte;
        }

    }

    void ValideNombre()
    {
        if(refBool.GetComponent<Verif>().totalvert==_nombre)
        {
            ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);

        }
        else
        {
            ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);

        }
    }

}

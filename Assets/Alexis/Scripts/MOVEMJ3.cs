using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MOVEMJ3 : MonoBehaviour
{
    public int nombre = 0;
    public GameObject refBool;
    public TextMeshProUGUI texteNombre;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        texteNombre.text = nombre;
    }

    void Change_Boutton_Gauche()
    {
        
            CurrentButton = ListeBouttons[index_boutton - 1];
        

    }

    void Change_Boutton_Droite()
    {
        
            CurrentButton = ListeBouttons[index_boutton + 1];
        

    }

}

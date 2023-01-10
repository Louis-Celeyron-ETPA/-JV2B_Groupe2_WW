using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MOVEMJ3 : MonoBehaviour
{
    public List<button> ListeBouttons;
    public Button CurrentButton = ListeBouttons[0];
    private int index_boutton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 void Change_Boutton_Haut()
    {
        while (index_boutton < 8) 
        {
            CurrentButton = ListeBouttons[index_boutton + 1];
            CurrentButton.High
                }
        
    }
    void Change_Boutton_Down()
    {
        while (index_boutton > 0)
        {
            CurrentButton = ListeBouttons[index_boutton - 1];
        }

    }

}

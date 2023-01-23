using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MOVEMJ3 : MonoBehaviour
{
    public List<Button> ListeBouttons;
    public Button CurrentButton ;
    private int index_boutton;
    public GameObject refBool;

    // Start is called before the first frame update
    void Start()
    {
        CurrentButton = ListeBouttons[0];
    }

    // Update is called once per frame
    void Update()
    {
        if(refBool.GetComponent<Move>().switchBool==true)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Change_Boutton_Haut();
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Change_Boutton_Down();
            }
        }
    }

 void Change_Boutton_Haut()
    {
        while (index_boutton < 8) 
        {
            CurrentButton = ListeBouttons[index_boutton + 1];
            ColorBlock colorVar = CurrentButton.colors;
            colorVar.highlightedColor = new Color(255, 0, 0);
            CurrentButton.colors = colorVar;
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

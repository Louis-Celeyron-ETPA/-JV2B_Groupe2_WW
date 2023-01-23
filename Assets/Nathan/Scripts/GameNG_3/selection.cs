using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace NatanG_minijeu3
{
    public class Selection : MonoBehaviour
{
    public int placementSelection;
    public int NumTueur;
    public GameObject Victory;
    public GameObject Defeat;


    public bool hatBool;
    public bool tieBool;
    public bool tallBool;

    public GameObject Yes;
    public GameObject No;

    public bool VerticalAxisUsed;

        void Start()
    {
        //------------------------------------- Random du meutrier
        placementSelection = 1;
        NumTueur = Random.Range(1, 6);
        print(NumTueur);
        //----------------------- meutrier 1
        if (NumTueur == 1)
        {
            hatBool = true;
            tieBool = false;
            tallBool = false;
        }
        //----------------------- meutrier 2
        if (NumTueur == 2)
            {
            hatBool = true;
            tieBool = true;
            tallBool = true;
        }
        //----------------------- meutrier 3
        if (NumTueur == 3)
        {
            hatBool = false;
            tieBool = true;
            tallBool = false;
        }
        //----------------------- meutrier 4
        if (NumTueur == 4)
        {
            hatBool = false;
            tieBool = false;
            tallBool = false;
        }
        //----------------------- meutrier 5
        if (NumTueur == 5)
        {
            hatBool = false;
            tieBool = true;
            tallBool = true;
        }


        //------------------------------------- Placement des indices
        //----------------------- indice Chapeau
        if (hatBool == true)
        {
            var myObject = Instantiate(Yes, new Vector3(7.7f, 2.56f, -9), Quaternion.identity);
        }
        else
        {
            var myObject = Instantiate(No, new Vector3(7.7f, 2.56f, -9), Quaternion.identity);
        }
        //----------------------- indice Cravate
        if (tieBool == true)
        {
            var myObject = Instantiate(Yes, new Vector3(7.1f, 0.58f, -9), Quaternion.identity);
        }
        else
        {
            var myObject = Instantiate(No, new Vector3(7.1f, 0.58f, -9), Quaternion.identity);
        }
        //----------------------- indice Taille
        if (tallBool == true)
        {
            var myObject = Instantiate(Yes, new Vector3(6.9f, -1.52f, -9), Quaternion.identity);
        }
        else
        {
            var myObject = Instantiate(No, new Vector3(6.9f, -1.52f,-9), Quaternion.identity);
        }
    }

        //------------------------------------- Position du selecteur
        public void SelectionGoRight() // Selection va à droite
        {
            if (!VerticalAxisUsed) // = if(isRightDown == false)
            {
                if (Defeat.transform.position.y != -4 && Victory.transform.position.y != -4 && transform.position.x < 3)
                {
                    VerticalAxisUsed = true;
                    transform.position += new Vector3(2.5f, 0);
                    placementSelection -= 1;
                }
            }
        }
        public void SelectionGoLeft() // Selection va à droite
        {
            if (!VerticalAxisUsed) // = if(isLeftDown == false)
            {
                if (Defeat.transform.position.y != -4 && Victory.transform.position.y != -4 && transform.position.x > -6)
                {
                    VerticalAxisUsed = true;
                    transform.position += new Vector3(-2.5f, 0);
                    placementSelection += 1;
                }
            }
        }
        public void Reset() // reset de VerticalAxisUsed
        {
            VerticalAxisUsed = false;
        }
        public void ValiderChoix()//Selection et V/D
        {
            if (NumTueur == placementSelection)
            {
                Victory.transform.position = new Vector3(0, -4);
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }
            else
            {
                Defeat.transform.position = new Vector3(0, -4);
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selection : MonoBehaviour
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
    // Start is called before the first frame update
    void Start()
    {
        placementSelection = 1;
        NumTueur = Random.Range(1, 6);
        print(NumTueur);
        if (NumTueur == 1)
        {
            hatBool = true;
            tieBool = false;
            tallBool = false;
        }
        if (NumTueur == 2)
        {
            hatBool = true;
            tieBool = true;
            tallBool = true;
        }
        if (NumTueur == 3)
        {
            hatBool = false;
            tieBool = true;
            tallBool = false;
        }
        if (NumTueur == 4)
        {
            hatBool = false;
            tieBool = false;
            tallBool = false;
        }
        if (NumTueur == 5)
        {
            hatBool = false;
            tieBool = true;
            tallBool = true;
        }

        if (hatBool == true)
        {
            var myObject = Instantiate(Yes, new Vector3(7.7f, 2.56f, -9), Quaternion.identity);

        }
        else
        {
            var myObject = Instantiate(No, new Vector3(7.7f, 2.56f, -9), Quaternion.identity);
        }
        if (tieBool == true)
        {
            var myObject = Instantiate(Yes, new Vector3(7.1f, 0.58f, -9), Quaternion.identity);

        }
        else
        {
            var myObject = Instantiate(No, new Vector3(7.1f, 0.58f, -9), Quaternion.identity);
        }
        if (tallBool == true)
        {
            var myObject = Instantiate(Yes, new Vector3(6.9f, -1.52f, -9), Quaternion.identity);

        }
        else
        {
            var myObject = Instantiate(No, new Vector3(6.9f, -1.52f,-9), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Defeat.transform.position.y != -4 && Victory.transform.position.y != -4)
        {
            if (transform.position.x < 3)
            {
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    transform.position += new Vector3(2.5f, 0);
                    placementSelection -= 1;
                }
            }
            if (transform.position.x > -6)
            {
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    transform.position += new Vector3(-2.5f, 0);
                    placementSelection += 1;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (NumTueur == placementSelection)
            {
                Victory.transform.position = new Vector3(0, -4);
            }
            else
            {
                Defeat.transform.position = new Vector3(0, -4);
            }
        }


    }
}

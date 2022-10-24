using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    public SpriteRenderer mr;
    public Color A = Color.cyan , B = Color.yellow, C = Color.magenta;
    public int couleur;
    public Vector2 targetLocation;
    public Vector2 targetLocation2;
    public Vector2 targetLocation3;
    public Transform target;
    public bool shouldGoToTarget;
    public float delta = 0.1f;
    //public Generation maref;
    //private int ind = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    /*void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            shouldGoToTarget = true;
            if (shouldGoToTarget)
            {
                maref.listeAssiette[ind].transform.position = Vector2.MoveTowards(maref.listeAssiette[ind].transform.position, targetLocation, delta);
                if (maref.listeAssiette[ind].transform.position == targetLocation)
                {
                    ind = ind + 1;
                }
            }
        }

        if (Input.GetKey(KeyCode.Z))
        {
            shouldGoToTarget = true;
            if (shouldGoToTarget)
            {
                Generation.listeAssiette[ind].transform.position = Vector2.MoveTowards(Generation.listeAssiette[ind].transform.position, targetLocation2, delta);
                if (Generation.listeAssiette[ind].transform.position == targetLocation2)
                {
                    ind = ind + 1;
                }
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            shouldGoToTarget = true;
            if (shouldGoToTarget)
            {
                Generation.listeAssiette[ind].transform.position = Vector2.MoveTowards(Generation.listeAssiette[ind].transform.position, targetLocation3, delta);
                if (Generation.listeAssiette[ind].transform.position == targetLocation3)
                {
                    ind = ind + 1;
                }
            }
        }

    }*/
}

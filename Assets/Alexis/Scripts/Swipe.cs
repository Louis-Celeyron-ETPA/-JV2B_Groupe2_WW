using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    public Color A = Color.cyan , B = Color.yellow, C = Color.magenta;
    public int couleur;
    public Vector3 targetLocation;
    public Vector3 targetLocation2;
    public Vector3 targetLocation3;
    public Transform target;
    public bool shouldGoToTarget;
    public float delta = 0.1f;
    public List<GameObject> liste;
    //public Generation maref;
    public int ind = 0;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            shouldGoToTarget = true;
            if (shouldGoToTarget)
            {
                liste[ind].transform.position = targetLocation;
                if (liste[ind].transform.position == targetLocation)
                {
                    ind = ind + 1;
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            shouldGoToTarget = true;
            if (shouldGoToTarget)
            {
                liste[ind].transform.position = targetLocation2;
                if (liste[ind].transform.position == targetLocation2)
                {
                    ind = ind + 1;
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            shouldGoToTarget = true;
            if (shouldGoToTarget)
            {
                liste[ind].transform.position = targetLocation3;
                if (liste[ind].transform.position == targetLocation3)
                {
                    ind = ind + 1;
                }
            }
        }

    }
}

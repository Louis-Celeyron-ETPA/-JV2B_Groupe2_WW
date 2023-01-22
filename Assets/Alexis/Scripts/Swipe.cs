using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Alexis
{

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
    public GameObject refGeneration;
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
                if (liste[ind].GetComponent<MeshRenderer>().material.color==Color.cyan)
                {
                    ind = ind + 1;
                }
                else 
                {
                    ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);  
                    print("zdqdqzq");
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            shouldGoToTarget = true;
            if (shouldGoToTarget)
            {
                liste[ind].transform.position = targetLocation2;
                if (liste[ind].GetComponent<MeshRenderer>().material.color==Color.magenta)
                {
                    ind = ind + 1;
                }
                 else 
                {
                    ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);  
                    print("zdqdqzq");
                }
            }
           
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            shouldGoToTarget = true;
            if (shouldGoToTarget)
            {
                liste[ind].transform.position = targetLocation3;
                if (liste[ind].GetComponent<MeshRenderer>().material.color==Color.yellow)
                {
                    ind = ind + 1;
                }
                else 
                {
                    ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);  
                    print("zdqdqzq");
                }
            }
            
        }
        if (ind>refGeneration.GetComponent<Generation>()._nbrATrier)
        {
            Debug.Log("yes");
            ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);  
        }

    }
    public void SwipeHaut()
    {
        shouldGoToTarget = true;
            if (shouldGoToTarget)
            {
                liste[ind].transform.position = targetLocation2;
                if (liste[ind].transform.position == targetLocation2)
                {
                    ind = ind + 1;
                }
                else 
                {
                    ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);  
                }
            }
    }

    public void SwipeGauche()
    {
        shouldGoToTarget = true;
            if (shouldGoToTarget)
            {
                liste[ind].transform.position = targetLocation;
                if (liste[ind].transform.position == targetLocation)
                {
                    ind = ind + 1;
                }
                else 
                {
                    ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);  
                }
            }
    }

    public void SwipeDroite()
    {
        shouldGoToTarget = true;
            if (shouldGoToTarget)
            {
                liste[ind].transform.position = targetLocation3;
                if (liste[ind].transform.position == targetLocation3)
                {
                    ind = ind + 1;
                }
                else 
                {
                    ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);  
                }
            }
    }
}
}

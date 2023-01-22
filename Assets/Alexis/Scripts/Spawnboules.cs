using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnboules : MonoBehaviour
{
    public GameObject Boule;
    private bool aSpawne = false;
    public int difficulte = 1;
    public int nbrBoules;
    // Start is called before the first frame update
    void Start()
    {
        if (difficulte==1)
        {
            nbrBoules = 10;
        }
        if (difficulte == 2)
        {
            nbrBoules = 15;
        }
        if (difficulte == 3)
        {
            nbrBoules = 20;
        }
        //Spawn();
    }
    public void Spawn()
    {
        if (aSpawne == false)
        {
            for (int i = 0; i < nbrBoules+1; i++)
            {
                //var newObject = Instantiate(objetASpawner, new Vector2(0.0f, -6.23f), Quaternion.identity);
                var newObject = Instantiate(Boule, new Vector3(Random.Range(-2,2),5, Random.Range(-2, 2)), Quaternion.identity);
            }
        }

        aSpawne = true;
    }
}

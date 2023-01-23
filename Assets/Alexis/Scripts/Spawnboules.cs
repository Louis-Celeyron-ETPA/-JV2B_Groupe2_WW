using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnboules : MonoBehaviour
{
    public GameObject boule;
    private bool _aSpawne = false;
    private int _nbrBoules;
    // Start is called before the first frame update
    void Start()
    {
        if (ManagerManager.DifficultyManager.GetDifficulty()==1)
        {
            _nbrBoules = 10;
        }
        if (ManagerManager.DifficultyManager.GetDifficulty() == 2)
        {
            _nbrBoules = 15;
        }
        if (ManagerManager.DifficultyManager.GetDifficulty() == 3)
        {
            _nbrBoules = 20;
        }
        //Spawn();
    }
    public void Spawn()
    {
        if (_aSpawne == false)
        {
            for (int i = 0; i < _nbrBoules+1; i++)
            {
                //var newObject = Instantiate(objetASpawner, new Vector2(0.0f, -6.23f), Quaternion.identity);
                var newObject = Instantiate(boule, new Vector3(Random.Range(-2,2),5, Random.Range(-2, 2)), Quaternion.identity);
            }
        }

        _aSpawne = true;
    }
}

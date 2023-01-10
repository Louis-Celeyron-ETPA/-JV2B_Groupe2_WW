using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NatanG_minijeu1
{
    public class CarSpawning : MonoBehaviour
    {
        //---------- Les voitures
        public GameObject CarToSpawn1;
        public GameObject CarToSpawn2;
        public GameObject CarToSpawn3;
        public GameObject CarToSpawn;

        public int nombreDeVoiture;
        public int i;
        private float time;

        void Update()
        {
            time += Time.deltaTime;

            //------------------------------------- Voir si toutes les voitures on spawn
            if (i == nombreDeVoiture && time >= 1.5f)
            {
                //ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }

            //------------------------------------- Création des voitures
            if (i != nombreDeVoiture)
            {
                if (time > 0.6f)
                {
                    //------------------------------------- random position voiture
                    int randomPositonY = Random.Range(1, 4);
                    float carPositonY = 1f;

                    //---------------------------- position 1
                    if (randomPositonY == 1)
                    {
                        carPositonY = 2.6f;
                    }

                    //---------------------------- position 3
                    else if (randomPositonY == 3)
                    {
                        carPositonY = -0.6f;
                    }

                    //---------------------------- position 2
                    else
                    {
                        ;
                    }


                    //------------------------------------- random asset voiture
                    int randomCars = Random.Range(1, 4);

                    //---------------------------- asset 1
                    if (randomCars == 1)
                    {
                        CarToSpawn = CarToSpawn1;
                    }

                    //---------------------------- asset 2
                    else if (randomCars == 2)
                    {
                        CarToSpawn = CarToSpawn2;
                    }

                    //---------------------------- asset 3
                    else
                    {
                        CarToSpawn = CarToSpawn3;
                    }

                    //------------------------------------- spawn voiture
                    var myObject = Instantiate(CarToSpawn, new Vector2(8.5f, carPositonY), Quaternion.identity);
                    time = 0;
                    i++;
                }
            }
        }
    }
}

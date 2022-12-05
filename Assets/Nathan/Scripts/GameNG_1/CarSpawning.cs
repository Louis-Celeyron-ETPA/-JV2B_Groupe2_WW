using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawning : MonoBehaviour
{
    public GameObject CarToSpawn1;
    public GameObject CarToSpawn2;
    public GameObject CarToSpawn3;
    public GameObject CarToSpawn;
    public GameObject signalétique;
    public int nombreDeVoiture;
    public int i;
    private float time;
    //public GameObject PlaneD;
    //public GameObject PlaneV;
    //public GameObject PlaneM;
    public bool verbeOnScreeen;
    // Start is called before the first frame update
    void Start()
    {
        verbeOnScreeen = false;
    }
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        //if (time >= 0.8f && verbeOnScreeen == true)
        //{
        //    PlaneM.transform.Translate(Vector3.forward * 8f);
        //    verbeOnScreeen = false;
        //    time = 0;
        //}

        if (i == nombreDeVoiture && time >= 1.5f)
        {
            //PlaneV.transform.position = new Vector3(PlaneV.transform.position.x, PlaneV.transform.position.y, 1.6f);
            print("victoire");
        }


        if (i != nombreDeVoiture && verbeOnScreeen == false) 
        { 
            if (time > 0.6f)
            {
                var newObject = Instantiate(signalétique, new Vector3(8f, 1,13.8f), Quaternion.identity);
                int randomPositonY = Random.Range(1, 4);
                float carPositonY = 1f;
                if (randomPositonY == 1)
                {
                    carPositonY = 2.6f;
                }
                else if (randomPositonY == 3)
                {
                    carPositonY = -0.6f;
                }
                else
                {
                    ;
                }
                int randomCars = Random.Range(1, 4);
                if (randomCars == 1)
                {
                    CarToSpawn = CarToSpawn1;
                }
                else if (randomCars == 2)
                {
                    CarToSpawn = CarToSpawn2;
                }
                else
                {
                    CarToSpawn = CarToSpawn3;
                }
                var myObject = Instantiate(CarToSpawn, new Vector2(8.5f, carPositonY), Quaternion.identity);
                time = 0;
                i++;
            }
        }
    }
}

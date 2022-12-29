using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Alexis
{
    public class Generation : MonoBehaviour
    {

        public GameObject objetASpawner;
        private int couleur;
        private Color A = Color.cyan, B = Color.yellow, C = Color.magenta;
        bool aTourne = false;
        public List<GameObject> listeAssiette = new List<GameObject>();
        public GameObject reference;

        // Start is called before the first frame update

        void Start()
        {
            Spawn();
            
        }
        public void Spawn()
        {
            if (aTourne == false)
            {
                for (int i = 0; i < 5; i++)
                {
                    //var newObject = Instantiate(objetASpawner, new Vector2(0.0f, -6.23f), Quaternion.identity);
                    var newObject = Instantiate(objetASpawner, new Vector3(0,0,0), Quaternion.identity);
                    couleur = Random.Range(1, 3);
                    if (couleur == 1)
                    {
                        newObject.GetComponent<MeshRenderer>().material.color = A;
                    }
                    if (couleur == 2)
                    {
                        newObject.GetComponent<MeshRenderer>().material.color = B;
                    }
                    if (couleur == 3)
                    {
                        newObject.GetComponent<MeshRenderer>().material.color = C;
                    }
                    listeAssiette.Add(newObject);
                }
                reference.GetComponent<Swipe>().liste = listeAssiette;
            }

            aTourne = true;
        }


    }
}

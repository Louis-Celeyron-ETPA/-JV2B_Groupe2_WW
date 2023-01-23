using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Alexis
{
    public class Generation : MonoBehaviour
    {

        public GameObject objetASpawner;
        private int _couleur;
        private Color _couleurA = Color.cyan, _couleurB = Color.yellow, _couleurC = Color.magenta;
        private bool _aTourne = false;
        public List<GameObject> listeAssiette = new List<GameObject>();
        public GameObject reference;
        public int nbrATrier = 25;

        // Start is called before the first frame update

        void Start()
        {
            Spawn();
            //je sais c'est crade mais c'est pour éviter que la victoire se trigger alors qu'il reste encore un objet à trier
            nbrATrier +=1;
            
        }
        public void Spawn()
        {
            if (_aTourne == false)
            {
                for (int i = 0; i < 25; i++)
                {
                    var newObject = Instantiate(objetASpawner, new Vector3(0,0,0), Quaternion.identity);
                    _couleur = Random.Range(1, 4);
                    if (_couleur == 1)
                    {
                        newObject.GetComponent<MeshRenderer>().material.color = _couleurA;
                    }
                    if (_couleur == 2)
                    {
                        newObject.GetComponent<MeshRenderer>().material.color = _couleurB;
                    }
                    if (_couleur == 3)
                    {
                        newObject.GetComponent<MeshRenderer>().material.color = _couleurC;
                    }
                    listeAssiette.Add(newObject);
                }
                reference.GetComponent<Swipe>().liste = listeAssiette;
            }

            _aTourne = true;
        }


    }
}

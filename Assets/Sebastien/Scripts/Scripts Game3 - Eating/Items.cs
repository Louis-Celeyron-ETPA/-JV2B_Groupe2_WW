using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace SebastienMiniGame3 {

    public class Items : MonoBehaviour

    {

        public GameObject cake;
        public GameObject bomb;

        public GameObject player;
        public GameObject cakeClone;
        public GameObject bombClone;

        private Animator anim;

        private bool isEating;
        public bool gameStart;

        public Text scoreText;
        public Text outcomeText;
        public Text difficultyText;


        public int requiredScore = 8;

        public string difficulty;



        // Start is called before the first frame update
        void Start()
        {
            //difficulty = "Hard";

            //if(difficulty == "Easy")
            //{

            //    InvokeRepeating("SpawnCake", 2f, 3f); // InvokeRepeating(fonction appell�e, temps de d�clenchement, r�p�tition x seconde)

            //    InvokeRepeating("SpawnBomb", 5f, 2f);

            //}

            //else if (difficulty == "Medium")
            //{

            //    InvokeRepeating("SpawnCake", 2f, 2f); // InvokeRepeating(fonction appellée, temps de déclenchement, répétition x seconde)

            //    InvokeRepeating("SpawnBomb", 4f, 1f);

            //}

            //else if (difficulty == "Hard")
            //{

            //    InvokeRepeating("SpawnCake", 2f, 1f); // InvokeRepeating(fonction appellée, temps de déclenchement, r�p�tition x seconde)

            //    InvokeRepeating("SpawnBomb", 3f, 0.5f);

            //}



            InvokeRepeating("SpawnCake", 2f, 1f); // InvokeRepeating(fonction appellée, temps de déclenchement, r�p�tition x seconde)

            InvokeRepeating("SpawnBomb", 3f, 0.5f);


            anim = gameObject.GetComponent<Animator>();

            gameStart = true;

            requiredScore = Random.Range(8, 20);

        }

        // Update is called once per frame
        void Update()
        {
            if (isEating && gameStart)
            {
                isEating = false;
                anim.Play("Running");
            }

            else if (requiredScore <= 0)

            {
                Victory();
            }

            scoreText.text = "À récupérer : " + requiredScore.ToString();

           

        }

        public void SpawnCake()
        {
            if(gameStart)
            {
                cakeClone = Instantiate(cake, (new Vector3((Random.Range(-8, 8)), 7, 0)), transform.rotation);
            }

        }

        public void SpawnBomb()
        {

            if (gameStart)
            {
                bombClone = Instantiate(bomb, (new Vector3((Random.Range(-4, 4)), 7, 0)), transform.rotation);

            }
        }

        public void Victory()
        {
            gameStart = false;
            outcomeText.text = "GG ma gueule";


        }

        public void Defeat()
        {
            gameStart = false;
            //Debug.Log("T'es mort");
            outcomeText.text = "T'es nul";


        }

        public void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.transform.gameObject.name == "cake(Clone)" && gameStart)
            {
                collision.gameObject.SetActive(false);
                Debug.Log("Bien joué");
                anim.Play("Eating");
                isEating = true;
                SubtractPoints();
            }

            else if (collision.transform.gameObject.name == "bomb(Clone)" && gameStart)
            {
                collision.gameObject.SetActive(false);
                anim.Play("Explode");
                isEating = true;
                Defeat();

            }
        }

  

        public void SubtractPoints()

        {
            requiredScore -= 1;
        }

    }



}

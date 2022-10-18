using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


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


    public int score = 0;

    public ChangeScene difficulty;



    // Start is called before the first frame update
    void Start()
    {
        difficulty = FindObjectOfType<ChangeScene>();

        if(difficulty.chosenDifficulty == "Easy")
        {

            InvokeRepeating("SpawnCake", 2f, 3f); // InvokeRepeating(fonction appellée, temps de déclenchement, répétition x seconde)

            InvokeRepeating("SpawnBomb", 5f, 2f);

        }

        else if (difficulty.chosenDifficulty == "Medium")
        {

            InvokeRepeating("SpawnCake", 2f, 2f); // InvokeRepeating(fonction appellée, temps de déclenchement, répétition x seconde)

            InvokeRepeating("SpawnBomb", 4f, 1f);

        }

        else if (difficulty.chosenDifficulty == "Hard")
        {

            InvokeRepeating("SpawnCake", 2f, 1f); // InvokeRepeating(fonction appellée, temps de déclenchement, répétition x seconde)

            InvokeRepeating("SpawnBomb", 3f, 0.5f);

        }


        anim = gameObject.GetComponent<Animator>();

        gameStart = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (isEating && gameStart)
        {
            isEating = false;
            anim.Play("Running");
        }

        else if (score >= 20)

        {
            Victory();
        }

        scoreText.text = score.ToString() + " Points";

        difficultyText.text = "Difficulty = " + difficulty.chosenDifficulty.ToString();
      




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
            AddPoints();

        }

        else if (collision.transform.gameObject.name == "bomb(Clone)" && gameStart)
        {
            collision.gameObject.SetActive(false);
            anim.Play("Explode");
            isEating = true;
            Defeat();

        }
    }

    public void AddPoints()

    {
        score += 1;
    }

    public void SubtractPoints()

    {
        score -= 1;
    }




}

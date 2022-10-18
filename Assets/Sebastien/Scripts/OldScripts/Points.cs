using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public static Points instance;
    public Text scoreText;
    int score = 0;
    // Start is called before the first frame update

    private void Awake()
    {

        instance = this;
    }
    void Start()
    {
        scoreText.text = score.ToString() + " Points";
    }

    public void AddPoints()

    {
        score += 1;
        scoreText.text = score.ToString() + " Points";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

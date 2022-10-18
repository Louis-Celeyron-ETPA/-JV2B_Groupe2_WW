using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
    public string chosenDifficulty;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LevelSelection(string difficultyName)
    {
        chosenDifficulty = difficultyName;
        Debug.Log(chosenDifficulty);
        SceneManager.LoadScene("Level");
    }

}

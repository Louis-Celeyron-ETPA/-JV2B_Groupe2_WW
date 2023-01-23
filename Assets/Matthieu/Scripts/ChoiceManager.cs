using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceManager : MonoBehaviour
{
    public List<PathManager> choices;
    public GameObject cursor;

    private PathManager _currentChoice;
    private int _currentIndex = 0; 
    private bool _activeChoosing = false;
    private bool _pointMort=true;
    // Start is called before the first frame update
    void Start()
    {
        _currentChoice = choices[_currentIndex];
        cursor.transform.position = _currentChoice.transform.position + new Vector3(0, 2, 0);
        cursor.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (_activeChoosing)
        {
            _currentChoice = choices[_currentIndex];
            cursor.transform.position = _currentChoice.transform.position + new Vector3(0, 2, 0);
        }
    }

    public void Sort()
    {
        var tempList = new List<PathManager>();
        while (tempList.Count < choices.Count)
        {
            var firstObject = choices[0];
            foreach (var item in choices)
            {
                if(item.transform.position.x < firstObject.transform.position.x && !tempList.Contains(firstObject))
                {
                    firstObject = item;
                }
            }
            tempList.Add(firstObject);
        }

        choices = tempList;

    }


    public void ChooseFish()
    {
        cursor.GetComponent<SpriteRenderer>().enabled = true;
        _activeChoosing = true;                                                     
    }

    public void ValidateChoice()
    {
        for(int i = 0; i < choices.Count; i++)
        {
            choices[i].sprite.color = choices[i].initialColor; 
        }

        Debug.Log(_currentChoice.name); 

        if(_currentChoice.name == "DollyFish")
        {
            ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
        }
        else
        {
            ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
        }
    }

    public void ChangeChoice(string dir)
    {
        if(!_pointMort)
        {
            return;
        }
        if(dir == "Left")
        {
            _currentIndex--;
        }else if(dir == "Right")
        {
            _currentIndex++; 
        }

        if(_currentIndex < 0)
        {
            _currentIndex = choices.Count - 1;
        }
        if(_currentIndex > choices.Count - 1)
        {
            _currentIndex = 0; 
        }
        _pointMort = false;
    }

    public void SetPointMort()
    {
        _pointMort = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace HARDYCorentin
{
    public class Second_Mini_Game_Movement_And_Attack : MonoBehaviour
    {
        public GameObject playablecharacter;
        public int winCondition = 0;
        public Difficulty df;
        // Start is called before the first frame update
        void Start()
        {
            df = ManagerManager.DifficultyManager;
        }

        // Update is called once per frame
        void Update()
        {
            //Attaque
            if (Physics.Raycast(playablecharacter.transform.position, -playablecharacter.transform.up, out var other, 1f))
            {
                Debug.Log("BBBBBBBBBBBBBBBBBBBBBBBBBBBBB");

                Debug.DrawRay(playablecharacter.transform.position, -playablecharacter.transform.up * 12);

                Destroy(other.transform.gameObject);
                winCondition = winCondition + 1;
            }
            //Contrôles
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                playablecharacter.transform.eulerAngles = new Vector3(0f, 0f, -90f);
                playablecharacter.transform.position = new Vector3(-1, 0, 0);
                Debug.DrawRay(playablecharacter.transform.position, -playablecharacter.transform.up * 1f);

            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                playablecharacter.transform.eulerAngles = new Vector3(0f, 0f, 90f);
                playablecharacter.transform.position = new Vector3(1, 0, 0);
                Debug.DrawRay(playablecharacter.transform.position, -playablecharacter.transform.up * 1f);
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                playablecharacter.transform.eulerAngles = new Vector3(0f, 0f, 180f);
                playablecharacter.transform.position = new Vector3(0, 1, 0);
                Debug.DrawRay(playablecharacter.transform.position, -playablecharacter.transform.up * 1f);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                playablecharacter.transform.eulerAngles = new Vector3(0f, 0f, 0f);
                playablecharacter.transform.position = new Vector3(0, -1, 0);
                Debug.DrawRay(playablecharacter.transform.position, playablecharacter.transform.up * 1f);
            }

            //Condition de victoire.
            if (winCondition >= 3*df.GetDifficulty())
            {
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }
        }
        //Fonctions de contrôles pour les contrôles communs.  
        public void MoveLeft()
        {
            playablecharacter.transform.eulerAngles = new Vector3(0f, 0f, -90f);
            playablecharacter.transform.position = new Vector3(-1, 0, 0);
            Debug.DrawRay(playablecharacter.transform.position, -playablecharacter.transform.up * 1f);
        }
        public void MoveRight()
        {
            playablecharacter.transform.eulerAngles = new Vector3(0f, 0f, 90f);
            playablecharacter.transform.position = new Vector3(1, 0, 0);
            Debug.DrawRay(playablecharacter.transform.position, -playablecharacter.transform.up * 1f);
        }
        public void MoveUp()
        {
            playablecharacter.transform.eulerAngles = new Vector3(0f, 0f, 180f);
            playablecharacter.transform.position = new Vector3(0, 1, 0);
            Debug.DrawRay(playablecharacter.transform.position, -playablecharacter.transform.up * 1f);
        }
        public void MoveDown()
        {
            playablecharacter.transform.eulerAngles = new Vector3(0f, 0f, -180f);
            playablecharacter.transform.position = new Vector3(0, -1, 0);
            Debug.DrawRay(playablecharacter.transform.position, playablecharacter.transform.up * 1f);
        }

    }
}
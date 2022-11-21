using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SebastienMiniGame2
{
    public class LevelsMiniJeu2 : MonoBehaviour
    {
        public int levelChosen = 0;
        public GameObject level1Tile;
        public GameObject level2Tile;
        public GameObject level3Tile;
        public GameObject level4Tile;



        public PlayerControls playerInstance;
        public PlayerControls victoryGoalInstance;



        // Start is called before the first frame update
        void Start()
        {
            level1Tile.SetActive(false);
            level2Tile.SetActive(false);
            level3Tile.SetActive(false);
            level4Tile.SetActive(false);

            //level1Tile.SetActive(false);

            if (levelChosen == 0)
            {
                //levelChosen = Random.Range(1, 4);
                levelChosen = 4;
                // random.range(min inclusive, max EXCLUSIVE)

            }

            Debug.Log(levelChosen);

        }

        // Update is called once per frame
        void Update()
        {
            if (levelChosen == 1)
            {
                level1Tile.SetActive(true);
                level2Tile.SetActive(false);
                level3Tile.SetActive(false);
                level4Tile.SetActive(false);



                Debug.Log(levelChosen);

                levelChosen = 0;

                playerInstance.player.transform.position = new Vector3(-7.6f,-1, 1.5f);
                victoryGoalInstance.victoryGoal.transform.position = new Vector3(9, 3.5f, 1.4f);
                victoryGoalInstance.victoryGoal.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            

            if (levelChosen == 2)
            {
                level1Tile.SetActive(false);
                level2Tile.SetActive(true);
                level3Tile.SetActive(false);
                level4Tile.SetActive(false);


                Debug.Log(levelChosen);

                levelChosen = 0;

                playerInstance.player.transform.position = new Vector3(-7.8f, 5, 1.5f);
                victoryGoalInstance.victoryGoal.transform.position = new Vector3(9, -1, 1.4f);
                victoryGoalInstance.victoryGoal.transform.rotation = Quaternion.Euler(0, 0, 0);

            }

            if (levelChosen == 3)
            {
                level1Tile.SetActive(false);
                level2Tile.SetActive(false);
                level3Tile.SetActive(true);
                level4Tile.SetActive(false);


                Debug.Log(levelChosen);

                levelChosen = 0;

                playerInstance.player.transform.position = new Vector3(7f, -3f, 1.5f);
                victoryGoalInstance.victoryGoal.transform.position = new Vector3(2.2f, -4.2f, 1.4f);
                victoryGoalInstance.victoryGoal.transform.rotation = Quaternion.Euler(0, 0, -90);

            }

            if (levelChosen == 4)
            {
                level1Tile.SetActive(false);
                level2Tile.SetActive(false);
                level3Tile.SetActive(false);
                level4Tile.SetActive(true);


                Debug.Log(levelChosen);

                levelChosen = 0;

                playerInstance.player.transform.position = new Vector3(7f, -3f, 1.5f);
                victoryGoalInstance.victoryGoal.transform.position = new Vector3(2.2f, -4.2f, 1.4f);
                victoryGoalInstance.victoryGoal.transform.rotation = Quaternion.Euler(0, 0, -90);

            }

        }
    }

}

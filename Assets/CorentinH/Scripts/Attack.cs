using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace HARDYCorentin
{

    public class Attack : MonoBehaviour
    {
        public GameObject player;
        public float difficulty = 1f;
        public Difficulty df;
        public int countdown = 0;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.RightArrow))
                Debug.DrawRay(player.transform.position, player.transform.right * 5f);
            {
                if (Physics.Raycast(player.transform.position, player.transform.right, out var other, 5f) & Input.GetKey(KeyCode.Space) & Input.GetKey(KeyCode.RightArrow))
                {
                    Debug.Log("BBBBBBBBBBBBBBBBBBBBBBBBBBBBB");
                    
                    Destroy(other.transform.gameObject);
                    countdown = countdown + 1;
                }
            }
            if (Input.GetKey(KeyCode.LeftArrow))
                Debug.DrawRay(player.transform.position, player.transform.right * -5f);
            {
                if(Physics.Raycast(player.transform.position, -player.transform.right, out var other, 5f) & Input.GetKey(KeyCode.Space) & Input.GetKey(KeyCode.LeftArrow))
                {
                    Debug.Log("AAAAAAAAAAAAAAAAAAAA");
                    
                    Destroy(other.transform.gameObject);
                    countdown = countdown + 1;
                }
            if (countdown >= 10*difficulty)
                {
                    ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
                    Debug.Log ("HEY ! YOU WON");
                } 
                
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    public GameObject carre;
    public float carreMoveLeft = -10f;
    public float carreMoveRight = 10f;
    public float carreMoveUp = 10f;
    public float carreMoveDown = -10f;
    public RectTransform myRectTreansform;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
 
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(carre.transform.position.x + carreMoveLeft, carre.transform.position.y, 0f);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector3(carre.transform.position.x + carreMoveRight, carre.transform.position.y, 0f);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector3(carre.transform.position.x, carre.transform.position.y + carreMoveUp, 0f);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = new Vector3(carre.transform.position.x, carre.transform.position.y + carreMoveDown, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow) & Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector3(carre.transform.position.x + carreMoveLeft / 2, carre.transform.position.y + carreMoveUp / 2, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow) & Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = new Vector3(carre.transform.position.x + carreMoveLeft / 2, carre.transform.position.y + carreMoveDown / 2, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow) & Input.GetKey(KeyCode.UpArrow)) 
        {
            transform.position = new Vector3(carre.transform.position.x + carreMoveRight / 2, carre.transform.position.y + carreMoveUp / 2, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow) & Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = new Vector3(carre.transform.position.x + carreMoveRight / 2, carre.transform.position.y + carreMoveDown / 2, 0f);
        }
    }
    
}
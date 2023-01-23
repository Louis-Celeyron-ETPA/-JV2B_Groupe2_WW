using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dylan;

public class Cursor : MonoBehaviour
{
    public GameObject carre;
    private float carreMoveLeft = -0.3f;
    private float carreMoveRight = 0.3f;
    private float carreMoveUp = 0.3f;
    private float carreMoveDown = -0.3f;
    public RectTransform myRectTreansform;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
 
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.position = new Vector3(carre.transform.position.x + carreMoveLeft, carre.transform.position.y, 2f);
        //}
        //else if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.position = new Vector3(carre.transform.position.x + carreMoveRight, carre.transform.position.y, 2f);
        //}
        //else if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    transform.position = new Vector3(carre.transform.position.x, carre.transform.position.y + carreMoveUp, 2f);
        //}
        //else if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    transform.position = new Vector3(carre.transform.position.x, carre.transform.position.y + carreMoveDown, 2f);
        //}
        //if (Input.GetKey(KeyCode.LeftArrow) & Input.GetKey(KeyCode.UpArrow))
        //{
        //    transform.position = new Vector3(carre.transform.position.x + carreMoveLeft / 2, carre.transform.position.y + carreMoveUp / 2, 2f);
        //}
        //if (Input.GetKey(KeyCode.LeftArrow) & Input.GetKey(KeyCode.DownArrow))
        //{
        //    transform.position = new Vector3(carre.transform.position.x + carreMoveLeft / 2, carre.transform.position.y + carreMoveDown / 2, 2f);
        //}
        //if (Input.GetKey(KeyCode.RightArrow) & Input.GetKey(KeyCode.UpArrow)) 
        //{
        //    transform.position = new Vector3(carre.transform.position.x + carreMoveRight / 2, carre.transform.position.y + carreMoveUp / 2,2f);
        //}
        //if (Input.GetKey(KeyCode.RightArrow) & Input.GetKey(KeyCode.DownArrow))
        //{
        //    transform.position = new Vector3(carre.transform.position.x + carreMoveRight / 2, carre.transform.position.y + carreMoveDown / 2, 2f);
        //}
    }
 
    
    public void MoveLeft()
    {
        transform.position = new Vector3(carre.transform.position.x + carreMoveLeft, carre.transform.position.y, 2f);

    }
    public void MoveRight()
    {
        transform.position = new Vector3(carre.transform.position.x + carreMoveRight, carre.transform.position.y, 2f);
    }
    public void MoveUp()
    {
        transform.position = new Vector3(carre.transform.position.x, carre.transform.position.y + carreMoveUp, 2f);
    }

    public void MoveDown()
    {
        transform.position = new Vector3(carre.transform.position.x, carre.transform.position.y + carreMoveDown, 2f);
    }
}
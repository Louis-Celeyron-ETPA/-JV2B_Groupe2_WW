using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public float curseurMoveLeft;
    public float curseurMoveRight;
    public float curseurMoveUp = 1f;
    public float curseurMoveDown;
    public GameObject curseur;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector3(0f, curseur.transform.position.y + curseurMoveUp);
            Debug.Log("A");
        }
    }
}

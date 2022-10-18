using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    public GameObject item;
    private SpriteRenderer _renderer;
    private Animator anim;

    public Items varStart;



    // Start is called before the first frame update
    void Start()
    {

        player = this.gameObject;
        _renderer = GetComponent<SpriteRenderer>();

        anim = gameObject.GetComponent<Animator>();
        anim.Play("Running");

    }

    // Update is called once per frame
    void Update()
    {

        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (varStart.gameStart && mousePosition.x > -8 && mousePosition.x < 8)

        {
            player.transform.position = new Vector2(mousePosition.x, -2.1f);

        }
        


        if (mousePosition.x < 0 && varStart.gameStart)

        {
           _renderer.flipX = true;
            
        }

        else
        {

            _renderer.flipX = false;

        }
    }

   
}

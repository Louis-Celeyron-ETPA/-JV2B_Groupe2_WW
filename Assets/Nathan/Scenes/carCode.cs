using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carCode : MonoBehaviour
{
    public Transform Plane;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && gameObject.transform.position.y < 3)
        {
            gameObject.transform.Translate(Vector3.up * 2f);
        }
        

        if (Input.GetKeyDown(KeyCode.DownArrow) && gameObject.transform.position.y > -1)
        {
            gameObject.transform.Translate(Vector3.down * 2f);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("mort");
        Destroy(gameObject);
    }


}

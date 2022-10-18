using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFusee : MonoBehaviour
{
    public float moveSpeed;

    public Rigidbody2D rb;
    private Vector3 velocity = Vector3.zero;

    // Start is called before the first frame update
    void FixedUpdate()
    {
        float verticalMovement = Input.GetKey(KeyCode.LeftArrow) * moveSpeed * Time.deltaTime;

        MovePlayer(verticalMovement);
    }

    // Update is called once per frame
    void MovePlayer(float _verticalMovement)
    {
        Vector3 targetVelocity = new Vector3(_verticalMovement, rb.velocity.x);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, .05f);
    }
}

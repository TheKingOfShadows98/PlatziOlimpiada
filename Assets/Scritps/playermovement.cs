using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float speed;
    public float jump_speed;
    // not implemented
    public float jump_height;

    public Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        rig.velocity = new Vector2(speed * horizontal, rig.velocity.y);

    }
    void Jump()
    {
        rig.velocity = new Vector2(rig.velocity.x, jump_speed);
    }

}

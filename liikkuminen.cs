using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class liikkuminen : MonoBehaviour
{
    public static bool isGround;
    Rigidbody2D body;
    public float speed = 5;
    public float jumpForce = 7;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);
        if(Input.GetKey(KeyCode.Space) && isGround)
        {
            body.velocity = new Vector2(body.velocity.x, jumpForce);
            
        }
        if(Input.GetAxis("Horizontal") > 0.01f)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (Input.GetAxis("Horizontal") <-0.01f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        anim.SetBool("Run", Input.GetAxis("Horizontal") != 0);

    }
}

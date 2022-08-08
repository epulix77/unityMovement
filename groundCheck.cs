using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundCheck : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //"Ground" is the tag name
        if (collision.collider.tag == "Ground")
        {
            liikkuminen.isGround = true;
        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            liikkuminen.isGround = false;
        }

    }
}

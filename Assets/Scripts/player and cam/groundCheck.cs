using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundCheck : MonoBehaviour
{
    public bool grounded;

    // when player collides with any object tagged "ground", they're grounded & able to jump
    void OnCollisionEnter2D( Collision2D collision)
	{
        if(collision.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }
	}

    // when player stops colliding with any object tagged "ground", they're not grounded & un able to jump
    void OnCollisionExit2D( Collision2D collision)
	{
        if(collision.gameObject.CompareTag("Ground"))
        {
            grounded = false;
        }
	}
}

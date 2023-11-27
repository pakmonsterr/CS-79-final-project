using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimation : MonoBehaviour
{
    public groundCheck GroundCheck;
    public Animator animator;

    Rigidbody2D playerRB;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerRB.velocity.x > 0)
        {
            Debug.Log("positive x");
            animator.SetInteger("anim_state", 1);
        }
        else if (playerRB.velocity.x < 0)
        {
            Debug.Log("negative x");
            animator.SetInteger("anim_state", 2);
        }
        else if (playerRB.velocity.x == 0)
        {
            Debug.Log("at rest");
            animator.SetInteger("anim_state", 0);
        }
    }
}

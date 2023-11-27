using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimation : MonoBehaviour
{
    // refs to other scripts
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
        if (!GroundCheck.grounded)
        {
            // jump = 2
            animator.SetInteger("anim_state", 2);
        }
        else if (playerRB.velocity.x != 0)
        {
            // run = 1
            animator.SetInteger("anim_state", 1);
        }
        else if (playerRB.velocity.x == 0)
        {
            // idle = 0
            animator.SetInteger("anim_state", 0);
        }
    }
}

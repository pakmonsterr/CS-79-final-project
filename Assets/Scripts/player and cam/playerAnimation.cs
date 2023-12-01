using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimation : MonoBehaviour
{
    // refs to other scripts
    [SerializeField] private groundCheck GroundCheck;
    [SerializeField] private Animator anim;
    [SerializeField] private dumbWaysToDie DumbWaysToDie;

    Rigidbody2D playerRB;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(DumbWaysToDie.spikeDeath);
        
        if (DumbWaysToDie.spikeDeath)
        {
            anim.SetTrigger("spikeDeath");
        }
        else if (!GroundCheck.grounded)
        {
            // jump = 2
            anim.SetInteger("anim_state", 2);
        }
        else if (playerRB.velocity.x != 0)
        {
            // run = 1
            anim.SetInteger("anim_state", 1);
        }
        else if (playerRB.velocity.x == 0)
        {
            // idle = 0
            anim.SetInteger("anim_state", 0);
        }
    }
}

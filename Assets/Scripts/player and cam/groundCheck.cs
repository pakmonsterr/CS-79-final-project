using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundCheck : MonoBehaviour
{
    public bool grounded;
    [SerializeField] private followPlayer FollowPlayer;
    [SerializeField] private float castDistance;
    [SerializeField] private LayerMask groundLayer;

    void Update()
    {
        grounded = (Physics2D.Raycast(transform.position, -transform.up, castDistance, groundLayer)) ? true : false;
        if (FollowPlayer.droppingInRespawn && grounded)
            {
                FollowPlayer.droppingInRespawn = false;
            }
    }
}

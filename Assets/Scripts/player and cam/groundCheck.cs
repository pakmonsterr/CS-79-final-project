using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundCheck : MonoBehaviour
{
    public bool grounded;
    [SerializeField] private float castDistance;
    [SerializeField] private LayerMask groundLayer;

    void Update()
    {
        // RaycastHit2D hit = Physics2D.Raycast(transform.position, -transform.up, castDistance, groundLayer);
        // Debug.Log(hit.collider);
        
        grounded = (Physics2D.Raycast(transform.position, -transform.up, castDistance, groundLayer)) ? true : false;
    }
}

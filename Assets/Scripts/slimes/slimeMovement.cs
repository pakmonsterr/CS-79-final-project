using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slimeMovement : MonoBehaviour
{
    [SerializeField] private slimeBehavior SlimeBehavior;
    [SerializeField] private float moveSpeed;
    private Rigidbody2D slimeRB;
    private float horizontalInput;
    private Vector2 facingLeft;
    
    void Start()
    {
        slimeRB = GetComponent<Rigidbody2D>();
        facingLeft = new Vector2(-transform.localScale.x, transform.localScale.y);
    }
    
    // Update is called once per frame
    void Update()
    {
        horizontalInput = SlimeBehavior.isFacingLeft ? (-1) : 1;
        slimeRB.velocity = new Vector2(horizontalInput * moveSpeed, slimeRB.velocity.y);
    }
}

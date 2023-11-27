using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    // inputs to speed & jump force
    public float moveSpeed;
    [SerializeField] float jumpForce;

    float horizontal;

    Rigidbody2D playerRB;

    public groundCheck GroundCheck;


    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerRB.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, playerRB.velocity.y);

        if ((Input.GetKeyDown("up") || Input.GetKeyDown("w")) && GroundCheck.grounded)
        {
            playerRB.AddForce(new Vector2(playerRB.velocity.x, jumpForce * 10));
        }
    }
}

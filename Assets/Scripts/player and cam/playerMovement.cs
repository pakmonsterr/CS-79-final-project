using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    // inputs to speed & jump force, ref to groundCheck script
    public float moveSpeed;
    public float jumpForce;
    public groundCheck GroundCheck;

    Rigidbody2D playerRB;

    private float horizontalInput;

    // sprite flipping stuff
    [HideInInspector]
    public bool isFacingLeft;
    public bool spawnFacingLeft;
    // TODO: put spawnFacingLeft in separate player/level instantiation script (later)
    private Vector2 facingLeft;

    // projectile stuff
    public GameObject ProjectilePrefab;
    public Transform launchOffset;


    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        facingLeft = new Vector2(-transform.localScale.x, transform.localScale.y);
        if(spawnFacingLeft)
        {
            transform.localScale = facingLeft;
            isFacingLeft = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        // horizontal movement
        playerRB.velocity = new Vector2(horizontalInput * moveSpeed, playerRB.velocity.y);

        // flip sprite if needed
        if (horizontalInput > 0 && isFacingLeft)
        {
            isFacingLeft = false;
            flip(gameObject);
        }
        else if (horizontalInput < 0 && !isFacingLeft)
        {
            isFacingLeft = true;
            flip(gameObject);
        }

        // jump mechanics
        if ((Input.GetKeyDown("up") || Input.GetKeyDown("w")) && GroundCheck.grounded)
        {
            playerRB.AddForce(new Vector2(playerRB.velocity.x, jumpForce * 10));
        }

        if (Input.GetKeyDown("space"))
        {
            var projectile = Instantiate(ProjectilePrefab, launchOffset.position, transform.rotation);
            if (isFacingLeft)
            {
                flip(projectile);
                projectileBehavior ProjectileBehavior = projectile.GetComponent<projectileBehavior>();
                ProjectileBehavior.shootLeft = true;
            } 
        }
    }

    // flips player according to isFacingLeft
    void flip(GameObject obj)
    {
        if (isFacingLeft)
        {
            obj.transform.localScale = facingLeft;
        }
        else if (!isFacingLeft)
        {
            obj.transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }
}

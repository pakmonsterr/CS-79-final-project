using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControls : MonoBehaviour
{

    // inputs to speed & jump force, ref to groundCheck script
    [SerializeField] private float moveSpeed;
    public float jumpForce;
    [SerializeField] private groundCheck GroundCheck;

    // other player stuff
    [SerializeField] private playerHandler PlayerHandler;
    [HideInInspector]
    public Rigidbody2D playerRB;

    [HideInInspector]
    public bool freezeInput;
    private float horizontalInput;

    // sprite flipping stuff
    [HideInInspector]
    public bool isFacingLeft;
    private Vector2 facingLeft;

    // projectile stuff
    [SerializeField] private GameObject ProjectilePrefab;
    [SerializeField] private Transform launchOffset;
    [SerializeField] float shootCooldown;
    private float shootCooldownTimer;

    // bank and shop stuff
    [SerializeField] private bankEnterTrigger BankEnterTrigger;


    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        facingLeft = new Vector2(-transform.localScale.x, transform.localScale.y);
        if(PlayerHandler.spawnFacingLeft)
        {
            transform.localScale = facingLeft;
            isFacingLeft = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // increment shootCooldownTimer
        shootCooldownTimer += Time.deltaTime;

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

        // ALL MOVEMENT
        if (!freezeInput)
        {
            // horizontal movement
            horizontalInput = Input.GetAxis("Horizontal");
            playerRB.velocity = new Vector2(horizontalInput * moveSpeed, playerRB.velocity.y);

            // jump mechanics
            if ((Input.GetKeyDown("up") || Input.GetKeyDown("w")) && GroundCheck.grounded)
            {
                playerRB.AddForce(new Vector2(playerRB.velocity.x, jumpForce * 10));
            }

            if (Input.GetKeyDown("space") && (shootCooldownTimer > shootCooldown) && !BankEnterTrigger.atBankDoor)
            {
                shootCooldownTimer = 0.0f;
                
                var projectile = Instantiate(ProjectilePrefab, launchOffset.position, transform.rotation);
                if (isFacingLeft)
                {
                    flip(projectile);
                    projectileBehavior ProjectileBehavior = projectile.GetComponent<projectileBehavior>();
                    ProjectileBehavior.shootLeft = true;
                } 
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

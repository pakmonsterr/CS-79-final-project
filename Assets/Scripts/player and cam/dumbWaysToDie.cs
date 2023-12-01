using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dumbWaysToDie : MonoBehaviour
{
    [SerializeField] private playerHandler PlayerHandler;
    [SerializeField] private playerControls PlayerControls;
    [SerializeField] private followPlayer FollowPlayer;
    [SerializeField] private GameObject Camera;

    [SerializeField] private float slimeHitCooldown;
    private float timer;

    [HideInInspector]
    public bool spikeDeath;
    private bool hitSlime;
    private CapsuleCollider2D capCollider;
    
    // Start is called before the first frame update
    void Start()
    {
        spikeDeath = false;
        hitSlime = false;
        capCollider = gameObject.GetComponent<CapsuleCollider2D>();
    }

    void Update()
    {
        timer += Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.CompareTag("bottomBoundary"))
        {
            if (!spikeDeath)
            {
                Debug.Log("died by falling");
                PlayerHandler.remainingLives -= 1;
            }
            else if (spikeDeath)
            {
                Debug.Log("hit boundary");

                spikeDeath = false;
                capCollider.isTrigger = false;
                PlayerControls.playerRB.constraints = RigidbodyConstraints2D.FreezeRotation;

                PlayerControls.freezeInput = false;
                FollowPlayer.freezeCamera = false;
            }

            transform.position = PlayerHandler.playerSpawn.transform.position;
            Camera.transform.position = new Vector3 (0, 0, -1);
        }
        else if (collider.gameObject.CompareTag("Spikes") && !spikeDeath)
        {
            Debug.Log("died by spikes");

            PlayerControls.freezeInput = true;
            FollowPlayer.freezeCamera = true;
            PlayerControls.playerRB.constraints = RigidbodyConstraints2D.FreezePositionX;

            PlayerHandler.remainingLives -= 1;

            PlayerControls.playerRB.velocity = Vector3.zero;
            PlayerControls.playerRB.AddForce(new Vector2(0, PlayerControls.jumpForce * 10));
            
            spikeDeath = true; 
            capCollider.isTrigger = true;
        }
        else if (collider.gameObject.CompareTag("Slime") && (timer > slimeHitCooldown))
        {
            timer = 0f;
            
            StartCoroutine(tempControlFreeze());
            Debug.Log(PlayerHandler.remainingLives);
            PlayerHandler.remainingLives -= 1;

            PlayerControls.playerRB.velocity = Vector3.zero;
            PlayerControls.playerRB.AddForce(new Vector2(PlayerControls.jumpForce * -5, PlayerControls.jumpForce * 10));
        }
    }

    private IEnumerator tempControlFreeze()
    {
        PlayerControls.freezeInput = true;
        yield return new WaitForSeconds(1.0f);
        PlayerControls.freezeInput = false;
    }
}

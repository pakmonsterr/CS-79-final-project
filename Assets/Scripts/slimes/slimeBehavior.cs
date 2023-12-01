using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slimeBehavior : MonoBehaviour
{
    [SerializeField] private playerHandler PlayerHandler;
    [SerializeField] private itemHandler ItemHandler;

    private Animator anim;

    private Rigidbody2D slimeRB;
    public bool isFacingLeft;
    private Vector2 facingLeft;
    
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        slimeRB = GetComponent<Rigidbody2D>();
        facingLeft = new Vector2(-transform.localScale.x, transform.localScale.y);
    }
    
    void OnTriggerEnter2D(Collider2D collider)
	{
        if(collider.gameObject.CompareTag("Projectile"))
        {
            StartCoroutine(slimeShot());
        }
        if(collider.gameObject.CompareTag("Player"))
        {
            PlayerHandler.remainingLives -= 1;
        }
        if(collider.gameObject.CompareTag("slimeBoundary"))
        {  
            // flip sprite if needed
            if (slimeRB.velocity.x > 0 && !isFacingLeft)
            {
                isFacingLeft = true;
                flip(gameObject);
            }
            else if (slimeRB.velocity.x < 0 && isFacingLeft)
            {
                isFacingLeft = false;
                flip(gameObject);
            }
        }
	}

    private IEnumerator slimeShot()
    {
        anim.SetTrigger("Shot");
        yield return new WaitForSeconds(ItemHandler.slimeDeathDuration);
        Destroy(gameObject);
    }

    // flips slime according to isFacingLeft
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

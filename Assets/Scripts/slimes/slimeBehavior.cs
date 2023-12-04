using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slimeBehavior : MonoBehaviour
{
    private playerHandler PlayerHandler;
    private itemHandler ItemHandler;
    private GameObject parentObj;
    private string slimeName;

    private Animator anim;

    private Rigidbody2D slimeRB;
    [HideInInspector] public bool isFacingLeft;
    private Vector2 facingLeft;
    
    void Start()
    {
        ItemHandler = GameObject.Find("Item Handler").GetComponent<itemHandler>();
        PlayerHandler = GameObject.Find("Player Handler").GetComponent<playerHandler>();
        parentObj = gameObject.transform.parent.gameObject;
        
        anim = gameObject.GetComponent<Animator>();
        slimeRB = GetComponent<Rigidbody2D>();
        facingLeft = new Vector2(-transform.localScale.x, transform.localScale.y);
    
        slimeName = gameObject.transform.parent.name;
        
        if(persistentData.Instance.slimesKilled.ContainsKey(slimeName))
        {
            if (persistentData.Instance.slimesKilled[slimeName] == true)
            {
                Destroy(parentObj);
                return;
            }
        }
        else
        {
            persistentData.Instance.slimesKilled.Add(slimeName, false);
        }
    }
    
    void OnTriggerEnter2D(Collider2D collider)
	{
        if(collider.gameObject.CompareTag("Projectile"))
        {
            StartCoroutine(slimeShot());
        }
        if(collider.gameObject.CompareTag("slimeBoundary") || collider.gameObject.CompareTag("Player"))
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
        if(persistentData.Instance.slimesKilled.ContainsKey(slimeName))
        {
            persistentData.Instance.slimesKilled[slimeName] = true;
        }
        
        anim.SetTrigger("Shot");
        yield return new WaitForSeconds(ItemHandler.slimeDeathDuration);
        Destroy(parentObj);
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

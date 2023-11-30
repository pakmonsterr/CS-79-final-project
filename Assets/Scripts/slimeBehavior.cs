using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slimeBehavior : MonoBehaviour
{
    [SerializeField] private playerHandler PlayerHandler;
    [SerializeField] private itemHandler ItemHandler;

    private Animator anim;
    
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        Debug.Log("shot");
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
	}

    private IEnumerator slimeShot()
    {
        anim.SetTrigger("Shot");
        yield return new WaitForSeconds(ItemHandler.slimeDeathDuration);
        Destroy(gameObject);
    }
}

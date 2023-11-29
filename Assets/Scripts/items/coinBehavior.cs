using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinBehavior : MonoBehaviour
{
    [SerializeField] private playerHandler PlayerHandler;

    private Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }


    void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.CompareTag("Player"))
        {
            PlayerHandler.playerCoins += 1;
        }
        StartCoroutine(collectAndDestroy());
    }

    private IEnumerator collectAndDestroy()
    {
        anim.SetTrigger("collected");
        yield return new WaitForSeconds(0.583f);
        Destroy(gameObject);
    }
}

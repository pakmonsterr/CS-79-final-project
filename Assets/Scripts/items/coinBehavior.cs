using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinBehavior : MonoBehaviour
{
    [SerializeField] private itemHandler ItemHandler;

    private Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();

        ItemHandler = GameObject.Find("Item Handler").GetComponent<itemHandler>();
    }


    void OnTriggerEnter2D(Collider2D collider) 
    {
        if(collider.gameObject.CompareTag("Player"))
        {
            persistentData.Instance.playerCoins += 1;
            StartCoroutine(collectAndDestroy());
        }
    }

    private IEnumerator collectAndDestroy()
    {
        anim.SetTrigger("collected");
        //Debug.Log(ItemHandler.slimeDeathDuration);
        yield return new WaitForSeconds(ItemHandler.coinAnimDuration);
        Destroy(gameObject);
    }
}

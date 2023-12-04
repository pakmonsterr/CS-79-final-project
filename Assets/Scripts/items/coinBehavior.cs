using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinBehavior : MonoBehaviour
{
    private itemHandler ItemHandler;
    private static persistentData PersistentData;
    private Animator anim;
    private string coinName;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();

        ItemHandler = GameObject.Find("Item Handler").GetComponent<itemHandler>();
        
        coinName = gameObject.transform.parent.name;
        
        if(persistentData.Instance.coinCollection.ContainsKey(coinName))
        {
            if (persistentData.Instance.coinCollection[coinName] == true)
            {
                Destroy(gameObject.transform.parent.gameObject);
                return;
            }
        }
        else
        {
            persistentData.Instance.coinCollection.Add(coinName, false);
        }
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
        if(persistentData.Instance.coinCollection.ContainsKey(coinName))
        {
            persistentData.Instance.coinCollection[coinName] = true;
        }
        
        anim.SetTrigger("collected");
        yield return new WaitForSeconds(ItemHandler.coinAnimDuration);
        Destroy(gameObject);
    }
}

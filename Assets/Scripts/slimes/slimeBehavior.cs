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
    public bool isFacingLeft;

    [SerializeField] private GameObject coinPrefab;
    
    void Start()
    {
        ItemHandler = GameObject.Find("Item Handler").GetComponent<itemHandler>();
        PlayerHandler = GameObject.Find("Player Handler").GetComponent<playerHandler>();
        parentObj = gameObject.transform.parent.gameObject;
        
        anim = gameObject.GetComponent<Animator>();
        slimeRB = GetComponent<Rigidbody2D>();
        
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
        if(collider.gameObject.CompareTag("slimeBoundary") || collider.gameObject.CompareTag("Player"));
        {  
            if (slimeRB.velocity.x > 0 && !isFacingLeft)
            {
                isFacingLeft = true;
            }
            else if (slimeRB.velocity.x < 0 && isFacingLeft)
            {
                isFacingLeft = false;
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
        yield return new WaitForSeconds(ItemHandler.slimeDeathDuration / 2);

        var coin = Instantiate(coinPrefab, transform.position, transform.rotation);
        coin.name = "C" + Random.Range(0f, 100f).ToString();
        yield return new WaitForSeconds(ItemHandler.slimeDeathDuration / 2);

        Destroy(parentObj);
    }
}

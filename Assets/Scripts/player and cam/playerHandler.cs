using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHandler : MonoBehaviour
{
    // basically this script stores info about the player-- it's not really meant to *do* anything
    // other than be a central place for storing all player vars and initialization stuff 
    
    public bool spawnFacingLeft;

    public Transform initialPlayerSpawn;

    [SerializeField] private Transform bankPlayerSpawn;
    [SerializeField] private Transform shopPlayerSpawn;

    [SerializeField] private int startingLives;
    [SerializeField] private GameObject Player;
    [SerializeField] private barrierTrigger BarrierTrigger;

    [SerializeField] private Sprite cardSprite;
    [SerializeField] private GameObject coinIcon;

    private static persistentData PersistentData;
    
    void Start() 
    {
        if (persistentData.Instance.bankVisited)
        {
            if (persistentData.Instance.cardType != "none")
            {
                coinIcon.GetComponent<SpriteRenderer>().sprite = cardSprite;
                coinIcon.transform.position = new Vector3 (coinIcon.transform.position.x, 3.35f, coinIcon.transform.position.z);
            }
            Player.transform.position = bankPlayerSpawn.position;
            persistentData.Instance.bankVisited = false;
            BarrierTrigger.raiseBarrier();
        }
        else if (persistentData.Instance.shopVisited)
        {
            Player.transform.position = shopPlayerSpawn.position;
            persistentData.Instance.shopVisited = false;
            BarrierTrigger.raiseBarrier();
        }
        else
        {
            Player.transform.position = initialPlayerSpawn.position;
        }
    }
    
    public void resetPlayer()
    {
        persistentData.Instance.remainingLives = startingLives;
        persistentData.Instance.playerCoins = 0;
    }

}

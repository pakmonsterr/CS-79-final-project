using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHandler : MonoBehaviour
{
    // basically this script stores info about the player-- it's not really meant to *do* anything
    // other than be a central place for storing all player vars and initialization stuff 
    
    public bool spawnFacingLeft;

    public Transform initialPlayerSpawn;

    public Transform bankPlayerSpawn;

    [SerializeField] private int startingLives;
    [SerializeField] private GameObject Player;
    [SerializeField] private bankBarrierTrigger BankBarrierTrigger;

    private static persistentData PersistentData;
    
    void Start() 
    {
        if (persistentData.Instance.bankVisited)
        {
            Player.transform.position = bankPlayerSpawn.position;
            persistentData.Instance.bankVisited = false;
            StartCoroutine(BankBarrierTrigger.raiseBarrier());
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

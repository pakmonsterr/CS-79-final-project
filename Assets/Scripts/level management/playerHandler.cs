using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHandler : MonoBehaviour
{
    // basically this script stores info about the player-- it's not really meant to *do* anything
    // other than be a central place for storing all player vars and initialization stuff 
    public bool spawnFacingLeft;

    public Transform playerSpawn;

    [SerializeField] private int startingLives;
    [HideInInspector]
    public int remainingLives;
    //[HideInInspector]
    public int playerCoins;

    public void resetPlayer()
    {
        remainingLives = startingLives;
        playerCoins = 0;
    }

}

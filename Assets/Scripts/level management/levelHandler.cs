using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelHandler : MonoBehaviour
{
    [SerializeField] private playerHandler PlayerHandler;

    void Start()
    {
        PlayerHandler.resetPlayer();
    }
    
    
    // Update is called once per frame
    void Update()
    {
        if (PlayerHandler.remainingLives == 0)
        {
            gameOver();
        }
    }

    void gameOver()
    {
        Debug.Log("GAME OVER.");
        PlayerHandler.resetPlayer();
    }
}

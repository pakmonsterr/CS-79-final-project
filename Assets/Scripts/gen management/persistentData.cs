using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class persistentData : MonoBehaviour
{
    public static persistentData Instance;
    [SerializeField] private playerHandler PlayerHandler;

    // persistent player stats
    public int remainingLives;
    public int playerCoins;
    public bool bankVisited;

    // persistent data shit
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        PlayerHandler.resetPlayer();
    }
        
}

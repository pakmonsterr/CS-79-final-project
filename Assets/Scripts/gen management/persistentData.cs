using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class persistentData : MonoBehaviour
{
    public static persistentData Instance;
    public playerHandler PlayerHandler;

    // persistent player stats
    public int remainingLives;
    public int playerCoins;
    public bool bankVisited;
    public bool shopVisited;
    public bool bankCheckpoint;
    public bool shopCheckpoint;

    // coin & slime collection data
    public Dictionary<string, bool> coinCollection = new Dictionary<string, bool>();

    public Dictionary<string, bool> slimesKilled = new Dictionary<string, bool>();

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

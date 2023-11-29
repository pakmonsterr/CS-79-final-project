using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStats : MonoBehaviour
{
    [SerializeField] private playerHandler PlayerHandler;
    [SerializeField] private GameObject Lives;
    [SerializeField] private GameObject Coins;
    
    // Update is called once per frame
    void Update()
    {
        Lives.GetComponent<TextMesh>().text = PlayerHandler.remainingLives.ToString();
        Coins.GetComponent<TextMesh>().text = PlayerHandler.playerCoins.ToString();
    }
}

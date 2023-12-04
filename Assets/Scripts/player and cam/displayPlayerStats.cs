using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayPlayerStats : MonoBehaviour
{
    private static persistentData PersistentData;
    [SerializeField] private GameObject Lives;
    [SerializeField] private GameObject Coins;
    
    // Update is called once per frame
    void Update()
{
    if (Lives != null && persistentData.Instance != null)
    {
        TextMesh livesTextMesh = Lives.GetComponent<TextMesh>();
        if (livesTextMesh != null)
        {
            livesTextMesh.text = persistentData.Instance.remainingLives.ToString();
        }
    }

    if (Coins != null && persistentData.Instance != null)
    {
        TextMesh coinsTextMesh = Coins.GetComponent<TextMesh>();
        if (coinsTextMesh != null)
        {
            coinsTextMesh.text = persistentData.Instance.playerCoins.ToString();
        }
    }
}
}

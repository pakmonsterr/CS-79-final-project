using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class displayPlayerStats : MonoBehaviour
{
    private static persistentData PersistentData;
    [SerializeField] private TMP_Text livesTextMesh, coinsTextMesh;
    
    // Update is called once per frame
    void Update()
{
    if (persistentData.Instance != null)
    {
        if (livesTextMesh != null)
        {
            livesTextMesh.text = persistentData.Instance.remainingLives.ToString();
        }
    }

    if (persistentData.Instance != null)
    {
        if (coinsTextMesh != null)
        {
            coinsTextMesh.text = persistentData.Instance.playerCoins.ToString();
        }
    }
}
}

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
        Lives.GetComponent<TextMesh>().text = persistentData.Instance.remainingLives.ToString();
        Coins.GetComponent<TextMesh>().text = persistentData.Instance.playerCoins.ToString();
    }
}

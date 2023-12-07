using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class levelEndDisplay : MonoBehaviour
{
    private static persistentData PersistentData;
    [SerializeField] private TMP_Text livesTM, coinsTM, cardTypeTM;

    // Update is called once per frame
    void Update()
    {
        livesTM.text = persistentData.Instance.remainingLives.ToString();
        coinsTM.text = persistentData.Instance.playerCoins.ToString();
        cardTypeTM.text = persistentData.Instance.cardType;
    }
}

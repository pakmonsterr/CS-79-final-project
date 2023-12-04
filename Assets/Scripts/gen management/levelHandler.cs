using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelHandler : MonoBehaviour
{
    [SerializeField] private playerHandler PlayerHandler;
    private static persistentData PersistentData;
    
    // Update is called once per frame
    void Update()
    {
        if (persistentData.Instance.remainingLives == 0)
        {
            Debug.Log("GAME OVER.");
            PlayerHandler.resetPlayer();
        }

        // REMOVE FOR FINAL (only for dev purposes while emmet works on bank)
        if (persistentData.Instance.bankVisited)
        {
            Debug.Log("reloading scene");
            SceneManager.LoadScene("Level 1");
        }
    }
}

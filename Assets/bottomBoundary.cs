using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottomBoundary : MonoBehaviour
{
    [SerializeField] private playerHandler PlayerHandler;
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject Camera;

    void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("died by falling");
            PlayerHandler.remainingLives -= 1;

            Player.transform.position = PlayerHandler.playerSpawn.transform.position;
            Camera.transform.position = new Vector3 (0, 0, -1);
        }
    }
}

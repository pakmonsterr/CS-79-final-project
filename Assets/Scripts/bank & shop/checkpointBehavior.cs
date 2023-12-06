using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointBehavior : MonoBehaviour
{
    private static persistentData PersistentData;
    
    private bool checkpointReached;
    private Animator anim;
    [SerializeField] private string Location;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        
        if ((Location == "Bank" && persistentData.Instance.bankCheckpoint) || (Location == "Shop" && persistentData.Instance.shopCheckpoint))
        {
            checkpointReached = true;
            anim.SetTrigger("Checkpoint");
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.CompareTag("Player") && !checkpointReached)
        {
            checkpointReached = true;
            if (Location == "Bank")
            {
                persistentData.Instance.bankCheckpoint = true;
            }
            if (Location == "Shop")
            {
                persistentData.Instance.shopCheckpoint = true;
            }
            anim.SetTrigger("Checkpoint");
        }
    }
}

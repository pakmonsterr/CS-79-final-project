using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bankBarrierTrigger : MonoBehaviour
{
    [SerializeField] private Animator barrierAnim;
    
    private void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.CompareTag("Player"))
        {
            barrierAnim.SetTrigger("barrierFall");
        }
    }
}

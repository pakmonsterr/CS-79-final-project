using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bankBarrierTrigger : MonoBehaviour
{
    [SerializeField] private Animator barrierAnim;
    [SerializeField] private float raiseBarrierAnimTime;
    private static persistentData PersistentData;
    
    private void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.CompareTag("Player"))
        {
            barrierAnim.SetTrigger("barrierFall");
        }
    }

    public IEnumerator raiseBarrier()
    {
        barrierAnim.SetTrigger("barrierRaise");
        yield return new WaitForSeconds(raiseBarrierAnimTime);
        Destroy(gameObject);
    }
}

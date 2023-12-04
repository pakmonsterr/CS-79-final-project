using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bankBarrierTrigger : MonoBehaviour
{
    [SerializeField] private Animator barrierAnim;
    [SerializeField] private float raiseBarrierAnimTime;
    [SerializeField] private GameObject barrier;
    private Rigidbody2D barrierRB;
    private static persistentData PersistentData;
    
    void Start() 
    {
        barrierRB = barrier.GetComponent<Rigidbody2D>();
        barrierAnim.enabled = false;
    }
    
    private void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("collided");
            barrierRB.gravityScale = 2;
        }
    }

    public IEnumerator raiseBarrier()
    {
        barrierAnim.enabled = true;
        barrierAnim.SetTrigger("barrierRaise");
        yield return new WaitForSeconds(raiseBarrierAnimTime + 0.5f);
        Destroy(barrier);
    }
}

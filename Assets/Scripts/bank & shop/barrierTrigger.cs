using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrierTrigger : MonoBehaviour
{
    [SerializeField] private Animator barrierAnim;
    [SerializeField] private float raiseBarrierAnimTime;
    [SerializeField] private GameObject barrier;
    [SerializeField] private PhysicsMaterial2D solidMaterial;
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
            if (barrierRB != null)
            {
                StartCoroutine(barrierFall());
            }
        }
    }

    public void raiseBarrier()
    {
        barrierAnim.enabled = true;
        barrierAnim.SetTrigger("barrierRaise");
    }

    private IEnumerator barrierFall()
    {
        barrierRB.gravityScale = 2;
        yield return new WaitForSeconds(2.0f);
        barrierRB.sharedMaterial = solidMaterial;
    }
}

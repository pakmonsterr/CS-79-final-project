using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileBehavior : MonoBehaviour
{
    [SerializeField] float projectileSpeed;
    [HideInInspector]
    public bool shootLeft = false;

    private Vector3 move;
    private Rigidbody2D projectileRB;

    void Start()
    {
        projectileRB = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        projectileRB.velocity = new Vector2((shootLeft ? (-1 * projectileSpeed) : projectileSpeed), projectileRB.velocity.y);
        transform.position = transform.position + move;
    }

    private void OnTriggerEnter2D(Collider2D collider) {
        if (collider.gameObject.CompareTag("Slime") || collider.gameObject.CompareTag("Ground") || collider.gameObject.CompareTag("rightBoundary"))
        {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileBehavior : MonoBehaviour
{
    public float projectileSpeed;
    public bool shootLeft = false;

    private Vector3 move;

    // Update is called once per frame
    void Update()
    {
        move = new Vector3((shootLeft ? (-1 * projectileSpeed) : projectileSpeed) / 100, 0f, 0f);
        transform.position = transform.position + move;
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Destroy(gameObject);
    }
}

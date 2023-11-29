using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileBehavior : MonoBehaviour
{
    [SerializeField] float projectileSpeed;
    [HideInInspector]
    public bool shootLeft = false;

    private Vector3 move;

    // Update is called once per frame
    void Update()
    {
        move = new Vector3((shootLeft ? (-1 * projectileSpeed) : projectileSpeed) / 1000, 0f, 0f);
        transform.position = transform.position + move;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Destroy(gameObject);
    }
}

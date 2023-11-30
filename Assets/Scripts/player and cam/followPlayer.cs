using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public GameObject player;

    private float x, y;
    
    // Update is called once per frame
    void Update()
    {
        x = (player.transform.position.x > 0) ? player.transform.position.x : gameObject.transform.position.x;
        y = Mathf.Max(0, Mathf.Lerp(gameObject.transform.position.y, player.transform.position.y, 2 * Time.deltaTime));
        
        gameObject.transform.position = new Vector3 (x, y, -1);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public GameObject player;
    
    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x > 0)
        {
            gameObject.transform.position = new Vector3 (player.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        
    }
}

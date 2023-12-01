using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private playerHandler PlayerHandler;
    public bool freezeCamera;
    private float x, y;
    
    void Start()
    {
        freezeCamera = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (!freezeCamera)
        {
            x = (player.transform.position.x > 0) ? player.transform.position.x : gameObject.transform.position.x;
            
            y = (player.transform.position.x == PlayerHandler.playerSpawn.transform.position.x) ? 0 : Mathf.Max(0, Mathf.Lerp(gameObject.transform.position.y, player.transform.position.y, 2 * Time.deltaTime));
        
            gameObject.transform.position = new Vector3 (x, y, -1);
        }
    }
}

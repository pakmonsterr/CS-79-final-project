using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private playerHandler PlayerHandler;
    [SerializeField] private float cameraSpeed;
    public bool freezeCamera, droppingInRespawn;
    private float x, y;
    private bool atMapEnd;
    
    void Start()
    {
        freezeCamera = false;
        droppingInRespawn = true;
    }
    
    // Update is called once per frame
    void Update()
    {
        //Debug.Log("respawn: " + droppingInRespawn);
        //Debug.Log("grounded: " + GroundCheck.grounded);
        
        if (!freezeCamera)
        {
            atMapEnd = (player.transform.position.x == PlayerHandler.initialPlayerSpawn.transform.position.x) || player.transform.position.x > 219f;
            
            x = (player.transform.position.x > 0) ? (atMapEnd ? 219f : player.transform.position.x) : gameObject.transform.position.x;
            
            y = (droppingInRespawn) ? 0 : Mathf.Max(0, Mathf.Lerp(gameObject.transform.position.y, player.transform.position.y, cameraSpeed * Time.deltaTime));
        
            gameObject.transform.position = new Vector3 (x, y, -1);
        }
    }
}

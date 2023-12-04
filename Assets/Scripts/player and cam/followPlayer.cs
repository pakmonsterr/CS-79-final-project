using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private playerHandler PlayerHandler;
    [SerializeField] private float cameraSpeed;
    public bool freezeCamera;
    private float x, y;
    private bool atMapEnd;
    
    void Start()
    {
        freezeCamera = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (!freezeCamera)
        {
            atMapEnd = (player.transform.position.x == PlayerHandler.initialPlayerSpawn.transform.position.x) || player.transform.position.x > 219f;
            
            x = (player.transform.position.x > 0) ? (atMapEnd ? 219f : player.transform.position.x) : gameObject.transform.position.x;
            
            y = (atMapEnd) ? 0 : Mathf.Max(0, Mathf.Lerp(gameObject.transform.position.y, player.transform.position.y, cameraSpeed * Time.deltaTime));
        
            gameObject.transform.position = new Vector3 (x, y, -1);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enterTrigger : MonoBehaviour
{
    [SerializeField] private GameObject entrancePopup;

    [HideInInspector]
    public bool atDoor;
    [SerializeField] private string sceneToLoad;
    
    private void Start() 
    {
        entrancePopup.SetActive(false);
        atDoor = false;
    }

    private void Update() 
    {
        if (Input.GetKeyDown("space") && atDoor)
        {
            Debug.Log("enter " + sceneToLoad);
            SceneManager.LoadScene(sceneToLoad);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.CompareTag("Player"))
        {
            entrancePopup.SetActive(true);
            atDoor = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider) {
        if(collider.gameObject.CompareTag("Player"))
        {
            entrancePopup.SetActive(false);
            atDoor = false;
        }
    }
}

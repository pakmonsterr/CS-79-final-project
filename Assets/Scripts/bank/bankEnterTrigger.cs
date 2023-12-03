using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bankEnterTrigger : MonoBehaviour
{
    [SerializeField] private GameObject entrancePopup;

    [HideInInspector]
    public bool atBankDoor;
    
    private void Start() 
    {
        entrancePopup.SetActive(false);
        atBankDoor = false;
    }

    private void Update() 
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("enter bank");
            SceneManager.LoadScene("Bank_REAL");
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.CompareTag("Player"))
        {
            entrancePopup.SetActive(true);
            atBankDoor = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider) {
        if(collider.gameObject.CompareTag("Player"))
        {
            entrancePopup.SetActive(false);
            atBankDoor = false;
        }
    }
}

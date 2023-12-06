using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class bankMenu : MonoBehaviour
{
    [SerializeField] private Button Deposit;
    [SerializeField] private Button Exit;
    [SerializeField] private Button Info;

    // Start is called before the first frame update
    void Start()
    {
        Deposit.onClick.AddListener(DepositOnClick);
        Exit.onClick.AddListener(ExitOnClick);
        Info.onClick.AddListener(InfoOnClick);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void DepositOnClick()
    {
        // Display deposit popup
        Debug.Log("Deposit clicked");
    }

    void ExitOnClick()
    {
        // Return to previous level
        Debug.Log("Exit clicked");
    }

    void InfoOnClick()
    {
        // Display info popup
        Debug.Log("Info clicked");
    }
}
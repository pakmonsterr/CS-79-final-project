using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bankMenu : MonoBehaviour
{
    [SerializeField] private GameObject Deposit;
    [SerializeField] private GameObject Exit;
    [SerializeField] private GameObject Info;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Deposit != null)
        {
            TextMesh depositTextMesh = Deposit.GetComponent<TextMesh>();
            if (depositTextMesh != null)
            {
                depositTextMesh.text = "Deposit";
            }
        }

        if (Exit != null)
        {
            TextMesh exitTextMesh = Exit.GetComponent<TextMesh>();
            if (exitTextMesh != null)
            {
                exitTextMesh.text = "Exit";
            }
        }

        if (Info != null)
        {
            TextMesh infoTextMesh = Info.GetComponent<TextMesh>();
            if (infoTextMesh != null)
            {
                infoTextMesh.text = "Info";
            }
        }
    }
}

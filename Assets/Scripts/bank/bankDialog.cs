using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Import the TextMeshPro namespace

public class bankDialog : MonoBehaviour
{
    public string[] dialog; // The dialog text
    private int index; // The current index of the dialog
    private bool inChoiceState; // Whether the user is in the choice state or not
    private string[] choices = { "Credit Card", "Debit Card" }; // The choices
    private int choiceIndex; // The current index of the choice

    [SerializeField] private TextMeshProUGUI DialogTextMeshPro; // The TextMeshProUGUI for displaying dialog
    [SerializeField] private TextMeshProUGUI ChoiceTextMeshPro; // The TextMeshProUGUI for displaying choices

    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        inChoiceState = false;
        dialog = new string[] {"Hello", "How are you?", "Goodbye", "Choose: Credit Card or Debit Card"};
        ShowDialog();
    }

    // Update is called once per frame
    void Update()
    {
        if (inChoiceState)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                choiceIndex = (choiceIndex - 1 + choices.Length) % choices.Length;
                ChoiceTextMeshPro.text = "Current choice: " + choices[choiceIndex];
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                choiceIndex = (choiceIndex + 1) % choices.Length;
                ChoiceTextMeshPro.text = "Current choice: " + choices[choiceIndex];
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                ChoiceTextMeshPro.text = "You chose " + choices[choiceIndex];
                inChoiceState = false;
            }
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            NextDialog();
        }
    }

    void ShowDialog()
    {
        if (index < dialog.Length)
        {
            // Show the dialog[index]
            DialogTextMeshPro.text = dialog[index];
            if (dialog[index].Contains("Choose:"))
            {
                inChoiceState = true;
                choiceIndex = 0; // Reset the choice index
                ChoiceTextMeshPro.text = "Current choice: " + choices[choiceIndex];
            }
        }
    }

    void NextDialog()
    {
        index++;
        ShowDialog();
    }
}

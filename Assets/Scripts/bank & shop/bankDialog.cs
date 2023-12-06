using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class bankDialog : MonoBehaviour
{
    public string[] dialog; // The dialog text
    private int index; // The current index of the dialog
    private bool inChoiceState; // Whether the user is in the choice state or not
    private string[] choices = { "Credit", "Debit" }; // The choices
    private int choiceIndex; // The current index of the choice

    [SerializeField] private TextMeshProUGUI DialogTextMeshPro; // The TextMeshProUGUI for displaying dialog
    [SerializeField] private TextMeshProUGUI ChoiceTextMeshPro; // The TextMeshProUGUI for displaying choices

    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        inChoiceState = false;
        dialog = new string[] {
            "Welcome to the bank! Now that you’ve collected some coins, it will be helpful to be able to spend them without having to carry the actual coins around everywhere you go. \n\n[spacebar to continue]",
            "Debit cards and credit cards are two helpful options for making purchases on the go, but they have major differences as well. \n\n[spacebar to continue]",
            "Debit cards pull money directly from your bank account. This means that you can spend only as much as you currently have in your account—no more. \n\n[spacebar to continue]",
            "This is helpful if you want to make sure you never spend more than you have, but may be limiting if you want to make large purchases to pay off later. \n\n[spacebar to continue]",
            "Credit cards don’t pull funds from your own bank account, but instead allow you to borrow a set amount of the bank’s money (this amount is called your “line of credit”)—which you must then pay back at the end of each level. \n\n[spacebar to continue]",
            "This is helpful for making large purchases that you know you can pay off later, but can lead you to accidentally spend more than you end up being able to repay. \n\n[spacebar to continue]",
            "This bank offers credit cards with the following terms: \n\nLine of credit: 10 coins (this means you can borrow up to 10 coins during each level) \n\nPenalty for missed payment: 2 lost lives (this means you will lose 2 lives if you fail to pay off your credit card by the end of the level) \n\n[spacebar to continue]",
            "Choose your card: \n\nCredit Card or Debit Card \n\n[spacebar to select]"
        };
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
                HighlightChoice(); // Highlight current choice
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                choiceIndex = (choiceIndex + 1) % choices.Length;
                HighlightChoice(); // Highlight current choice
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                DialogTextMeshPro.text = "You chose " + choices[choiceIndex]; // Confirm choice
                inChoiceState = false; // Exit choice state
                // Perform any additional logic needed after making a choice
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
            DialogTextMeshPro.text = dialog[index]; // Show the current dialog
            if (dialog[index].Contains("Choose your card:"))
            {
                inChoiceState = true; // Enter choice state
                choiceIndex = 0; // Reset the choice index
                DisplayChoices(); // Display all choices
            }
        }
    }

    void DisplayChoices()
    {
        ChoiceTextMeshPro.text = string.Join("\n", choices); // Display all choices
        HighlightChoice(); // Highlight the first choice by default
    }

    void HighlightChoice()
    {
        // Remove previous highlighting
        string text = ChoiceTextMeshPro.text.Replace("<color=red>", "").Replace("</color>", "").Replace("<u>", "").Replace("</u>", "");
        // Split the text into lines
        string[] lines = text.Split('\n');
        // Highlight the current choice
        lines[choiceIndex] = "<color=red><u>" + lines[choiceIndex] + "</u></color>";
        // Join the lines back together
        ChoiceTextMeshPro.text = string.Join("\n", lines);
    }

    void NextDialog()
    {
        if (index < dialog.Length - 1) // Check if more dialogues are available
        {
            index++;
            ShowDialog();
        }
        else
        {
            DialogTextMeshPro.text = ""; // Optionally clear the dialog text or handle the dialogue end
            ChoiceTextMeshPro.text = "";
            // Here, you might disable the dialogue UI or trigger other game events
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class shopDialog : MonoBehaviour
{
    private bool inConfirmationState;
    public string[] dialog; // The dialog text
    private int index; // The current index of the dialog
    private bool inChoiceState; // Whether the user is in the choice state or not
    private string[] choices = { "Speed Coffee: 5 coins", "Jump Potion: 4 coins", "Mystery Outfit: 5 coins" }; // The choices
    private int choiceIndex; // The current index of the choice
    private static persistentData PersistentData;

    [SerializeField] private TextMeshProUGUI DialogTextMeshPro; // The TextMeshProUGUI for displaying dialog
    [SerializeField] private TextMeshProUGUI ChoiceTextMeshPro; // The TextMeshProUGUI for displaying choices

    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        inChoiceState = false;
        dialog = new string[] {
            "Welcome to the shop, brave traveler.",
            "What would you like to purchase for your journey? Choose wisely...",
            "Our items:"
        };
        ShowDialog();
    }

void Update()
{
    if (inConfirmationState)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            persistentData.Instance.shopVisited = true;
            SceneManager.LoadScene("Level 1");
        }
    }
    else if (inChoiceState)
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
            DialogTextMeshPro.text = "Your purchase " + choices[choiceIndex] + "\n[spacebar to exit]"; // Confirm choice
            inChoiceState = false; // Exit choice state
            inConfirmationState = true;
            if (choices[choiceIndex].Contains("Speed Coffee"))
            {
                persistentData.Instance.moveSpeed += 4;
                if ((persistentData.Instance.playerCoins - 5) < 0)
                {
                    Debug.Log("not enough coins");
                    if (persistentData.Instance.cardType == "Credit")
                    {
                        persistentData.Instance.playerCoins -= 5;
                    }
                }
                else 
                {
                    persistentData.Instance.playerCoins -= 5;
                }
                
            }
            else if (choices[choiceIndex].Contains("Jump Potion"))
            {
                persistentData.Instance.jumpForce += 15;
                persistentData.Instance.playerCoins -= 4;
            }
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
            if (dialog[index].Contains("Our items:"))
            {
                inChoiceState = true; // Enter choice state
                choiceIndex = 0; // Reset the choice index
                DisplayChoices(); // Display all choices
            }
        }
    }

    void DisplayChoices()
    {
        string cardChoicePrompt = "Our items:";
        ChoiceTextMeshPro.text = cardChoicePrompt + "\n" + string.Join("\n", choices); // Display all choices
        HighlightChoice(); // Highlight the first choice by default
    }

    void HighlightChoice()
    {
        // Remove previous highlighting
        string text = ChoiceTextMeshPro.text.Replace("<color=red>", "").Replace("</color>", "").Replace("<u>", "").Replace("</u>", "");
        // Split the text into lines
        string[] lines = text.Split('\n');
        // Highlight the current choice
        lines[choiceIndex + 1] = "<color=red><u>" + lines[choiceIndex + 1] + "</u></color>"; // Add 1 to choiceIndex to skip the prompt
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

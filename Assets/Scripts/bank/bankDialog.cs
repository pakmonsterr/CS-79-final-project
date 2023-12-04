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
        dialog = new string[] {"Welcome to the bank! Now that you’ve collected some coins, it will be helpful to be able to spend them without having to carry the actual coins around everywhere you go.", "Debit cards and credit cards are two helpful options for making purchases on the go, but they have major differences as well.", "Debit cards pull money directly from your bank account. This means that you can spend only as much as you currently have in your account—no more.", "This is helpful if you want to make sure you never spend more than you have, but may be limiting if you want to make large purchases to pay off later", "Credit cards don’t pull funds from your own bank account, but instead allow you to borrow a set amount of the bank’s money (this amount is called your “line of credit”)—which you must then pay back at the end of each level", "This is helpful for making large purchases that you know you can pay off later, but can lead you to accidentally spend more than you end up being able to repay", "Choose: Credit Card or Debit Card"};
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

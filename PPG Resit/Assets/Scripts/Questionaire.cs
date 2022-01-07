using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Questionaire : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject ChoicePanel;
    public GameObject Choice01;
    public GameObject Choice02;
    public GameObject continueButton;
    public Text ButtonText1;
    public Text ButtonText2;
    public int ChoiceMade;
    public Text ObjectiveText;


    public void Start()
    {
        ChoicePanel.SetActive(false);
        ObjectiveText.GetComponent<Text>().text = "Find your class";
        ButtonText1.text = "Yes!";
        ButtonText2.text = "No thanks.";
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        ChoicePanel.SetActive(true);
        continueButton.SetActive(false);
        TextBox.GetComponent<Text>().text = "Before you can enter the university you are stopped by a fellow student who approaches you with a question, Would you like to take a survey for the chance to win a free plastic raincoat?";
    }

    //Dialogue Options for the Questionaire Interaction
    public void ChoiceOption1()
    {
        TextBox.GetComponent<Text>().text = "You completed the survey to the besy of your ability even though you could read any of the questions on it.";
        ChoiceMade = 1;

    }
    public void ChoiceOption2()
    {
        TextBox.GetComponent<Text>().text = "You say that you do not speak Dutch and therefore could not possibly take the survey. You continue inside the school.";
        ChoiceMade = 2;
    }

    //Calls this to close dialogue menu
    public void closeMenu()
    {
        ChoicePanel.SetActive(false);
    }

    // Waits for the player to make a decision to then disable buttons
    void FixedUpdate()
    {
        if (ChoiceMade >= 1)
        {
            Choice01.SetActive(false);
            Choice02.SetActive(false);
            continueButton.SetActive(true);
        }
    }
}

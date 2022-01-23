using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TravelChoice : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject ChoicePanel;
    public GameObject Choice02;
    public Text ButtonText1;
    public Text ButtonText2;
    public GameObject ObjectiveBox;
    public Text ObjectiveText;


    public void Start()
    {
        ChoicePanel.SetActive(false);
        ObjectiveText.GetComponent<Text>().text = "Decide how you will get to class.";
        ButtonText1.text = "Yes";
        ButtonText2.text = "No";
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
            ChoicePanel.SetActive(true);
        TextBox.GetComponent<Text>().text = "Should I take my bike to school?";
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
            ChoicePanel.SetActive(false);
    }
    public void ChoiceOption2()
    {
        ChoicePanel.SetActive(false);
    }
}

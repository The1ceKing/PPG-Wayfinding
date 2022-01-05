using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WrongDoor : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject continueButton;
    public Text ObjectiveText;
    public GameObject ChoicePanel;
    public GameObject Choice01;
    public GameObject Choice02;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
            ChoicePanel.SetActive(true);
            Choice01.SetActive(false);
            Choice02.SetActive(false);
        continueButton.SetActive(true);
        TextBox.GetComponent<Text>().text = "This is the wrong classroom, keep looking!";
    }

    private void closeMenu ()
    {
        ChoicePanel.SetActive(false);
    }
}

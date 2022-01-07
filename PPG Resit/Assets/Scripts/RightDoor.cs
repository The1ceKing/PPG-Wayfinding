using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightDoor : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject continueButton;
    public Text ObjectiveText;
    public GameObject ChoicePanel;
    public GameObject Choice01;
    public GameObject Choice02;
    public Button contButton;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Button btn = contButton.GetComponent<Button>();
        if (collision.gameObject.name == "Player")
            btn.onClick.AddListener(changescene);
            ChoicePanel.SetActive(true);
            Choice01.SetActive(false);
            Choice02.SetActive(false);
        continueButton.SetActive(true);
        TextBox.GetComponent<Text>().text = "You finally found your classroom! Time to attend the lession.";
    }

    public void changescene()
    {
        Debug.Log("You have found the right door!");
    }

}

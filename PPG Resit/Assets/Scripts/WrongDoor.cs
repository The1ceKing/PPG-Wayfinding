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
    Collider2D m_Collider;

    void Start()
    {
        //Fetch the GameObject's Collider (make sure it has a Collider component)
        m_Collider = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
            ChoicePanel.SetActive(true);
            Choice01.SetActive(false);
            Choice02.SetActive(false);
        continueButton.SetActive(true);
        TextBox.GetComponent<Text>().text = "This is the wrong classroom, keep looking!";
    }

    //Disables Trigger Collider on exiting the collider
    public void OnTriggerExit2D(Collider2D other)
    {
        ChoicePanel.SetActive(false);
        m_Collider.enabled = false;
    }
}

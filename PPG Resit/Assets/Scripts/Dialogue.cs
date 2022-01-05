using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public Text DialogueBox;
    public GameObject continueDialogue;
    private int counter = 0;
    private string[] nextsentence;
    // Start is called before the first frame update
    void Start()
    {
        //creates a list of four texts and saves the original as the first
        nextsentence = new string[4];
        nextsentence[0] = DialogueBox.text;
        nextsentence[1] = "Hello";
        nextsentence[2] = "Goodbye";
        nextsentence[3] = "World";
    }

    //cycles through the four texts

    public void continueButton()
    {
        counter++;
        DialogueBox.text = nextsentence[counter];
        if (counter == 3)
        {
            counter = -1;
        }
    }
}
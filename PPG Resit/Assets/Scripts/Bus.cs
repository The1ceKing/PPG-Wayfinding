using System;
using System.Collections;
using System.Collections.Generic;
using Packages.Rider.Editor.UnitTesting;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Bus : MonoBehaviour
{
    private int BusTime;
    public TextMeshProUGUI buscomingTime;
    
    public BoxCollider2D busBox;
    
    public GameObject ChoicePanel;
    public GameObject TextBox;
    
    private void Start()
    {
        BusTimeSetter();
        busBox.enabled = false;
    }
    private void OnEnable()
    {
        TimeManager.OnMinuteChanged += TimeCheck;
    }

    private void OnDisable()
    {
        TimeManager.OnMinuteChanged -= TimeCheck;
    }

    private void BusTimeSetter()
    {
        //Generates a number between 1 & 2 and then updates bus text component
        var busTime = (BusTime = Random.Range(1, 3));
        if (busTime == 1)
        {
            buscomingTime.GetComponent<TextMeshProUGUI>().text = "10:10";
            buscomingTime.GetComponent<TextMeshProUGUI>().color = Color.green; 
            Debug.Log("The Bus will come at 10:10");
        }
        else
        {
            buscomingTime.GetComponent<TextMeshProUGUI>().text = "10:30";
            buscomingTime.GetComponent<TextMeshProUGUI>().color = Color.red; 
            Debug.Log("The Bus will come at 10:30");
        }
    }
    private void TimeCheck()
    {

        if (TimeManager.Hour == 10 && TimeManager.Minute == 10 && BusTime == 1)
        {
            StartCoroutine(MoveBus());
        }
        else if (TimeManager.Hour == 10 && TimeManager.Minute == 30 && BusTime == 2)
        {
            StartCoroutine(MoveBus());
        }
    }

    private IEnumerator MoveBus()
    {
        transform.position = new Vector3(-20f, 2.87f, 0);
        Vector3 targetPos = new Vector3(18.5f, 2.87f, 0);
        Vector3 currentPos = transform.position;

        float timeElapsed = 0;
        float timeToMove = 3;

        while (timeElapsed < timeToMove)
        {
            transform.position = Vector3.Lerp(currentPos, targetPos, timeElapsed / timeToMove);
            timeElapsed += Time.deltaTime;
            yield return null;
        }

        if (timeElapsed >= 3)
        {
            Debug.Log("Bus has stopped");
            busBox.enabled = true;
        }
        
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
            ChoicePanel.SetActive(true);
        TextBox.GetComponent<Text>().text = "Will you take the bus?";
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
            ChoicePanel.SetActive(false);
    }
}

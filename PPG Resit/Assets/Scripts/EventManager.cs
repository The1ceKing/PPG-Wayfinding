using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventManager : MonoBehaviour
{

    public bool isRaining;
    public float rainMultiplier;
    private Scene scene;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log(scene.buildIndex);
    }

    // Update is called once per frame
    void Update()
    {
        
        //If the weather forecast is rainy then effect something in the next scene
        if (scene.buildIndex == 0 && GameObject.Find("Phone").GetComponent<Phone>().isRaining)
        {
            isRaining = true;
        }

        if (scene.buildIndex == 1)
        {
            Debug.Log("Activate Rain Multiplier");
        }
    }
}

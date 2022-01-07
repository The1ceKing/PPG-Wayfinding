using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeController : MonoBehaviour
{
    float currentSpeed = 0f;
    float maxSpeed = 10f;
    public float movementSpeed = 5.0f;
    public GameObject player;
    private float screenCenterX;
    // New variables :
    public float accelerationTime = 60;
    private float minSpeed;
    private float time;

    private void Start()
    {

        minSpeed = currentSpeed;
        time = 0;
    }


    private void Update()
    {
        currentSpeed = Mathf.SmoothStep(minSpeed, maxSpeed, time / accelerationTime);
        transform.position -= -transform.forward * -currentSpeed * Time.deltaTime;
        time += Time.deltaTime;
    }
}
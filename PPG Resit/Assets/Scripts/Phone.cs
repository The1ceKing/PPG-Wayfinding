using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UIElements.Image;

public class Phone : MonoBehaviour
{
    private Animator animator;
    public Texture[] weatherStatus = new Texture[0];
    public RawImage currentWeather;
    public int rainOrShine;
    
    void Start()
    {
        animator = GetComponent<Animator>();
        //Setting the weather on phone
        rainOrShine = Random.Range(1,3);
        if (rainOrShine == 1)
        {
            currentWeather.texture = weatherStatus[0];
            Debug.Log("Rain");
        }
        else
        {
            currentWeather.texture = weatherStatus[1];
            Debug.Log("Sun");
        }
        
    }
    
    //When the E key is pressed, the player will either open the phone element or close it
    void Update()
    {
        if (Input.GetKeyDown("e") && animator.GetBool("IsOpen"))
        {
            animator.SetBool("IsOpen", false);
        }
        else if (Input.GetKeyDown("e"))
        {
            animator.SetBool("IsOpen", true);
        }
    }
    

}

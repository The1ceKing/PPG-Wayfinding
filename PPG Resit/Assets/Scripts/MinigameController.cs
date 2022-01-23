using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MinigameController : MonoBehaviour
{
    public Rigidbody2D rb;

    public float moveSpeed = 5;

    public GameObject GameOverMenu;

    public Animator animator;
    public Animation anim;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        anim = GetComponent<Animation>();
    }

//Movement controls and speed of the player
    void Update()
    {
        float moveDirection = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveDirection * moveSpeed, 0);
    }

    //Checking if the player hit any obstacles
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Obstacle"))
        {
            animator.SetTrigger("gameOver");
            GameOverMenu.SetActive(true);
        }
    }

    //Function I connected to a button to the game over screen to reset the mini-game.
    public void ResetGame()
    {
        SceneManager.LoadScene("Bike Minigame");
    }
}

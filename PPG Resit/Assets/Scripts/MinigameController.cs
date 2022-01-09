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

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveDirection = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveDirection * moveSpeed, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Obstacle"))
        {
            animator.SetTrigger("gameOver");
            GameOverMenu.SetActive(true);
        }
    }

    public void ResetGame()
    {
        SceneManager.LoadScene("Bike Minigame");
    }
}

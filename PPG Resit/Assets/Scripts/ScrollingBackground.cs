using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{

    public new BoxCollider2D collider;
    public Rigidbody2D rb;
    private float height;
    private float scrollSpeed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        height = collider.size.y/2;
        collider.enabled = false;

        rb.velocity = new Vector2(scrollSpeed, -5);
        ResetObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -height)
        {
        //Vector2 resetPosition = new Vector2(0, height * -0.02f);
        Vector2 resetPosition = new Vector2(height * 0f, 40);
        transform.position = (Vector2)transform.position + resetPosition;
            ResetObstacle();
        }
    }

    void ResetObstacle()
    {
        transform.GetChild(0).localPosition = new Vector3(Random.Range(-0.4f, 0.4f), 0, 0);
    }
}

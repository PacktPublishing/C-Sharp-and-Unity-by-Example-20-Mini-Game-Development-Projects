using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Rigidbody2D rb;
    Animator anim;

    [SerializeField]
    float jumpForce;

    bool grounded;
    bool gameOver = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0) && !gameOver)
        {
            if (grounded)
            {
                Jump();
            }
            
        }

	}


    void Jump()
    {
        grounded = false;

        rb.velocity = Vector2.up * jumpForce;

        anim.SetTrigger("Jump");

        GameManager.instance.IncrementScore();

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {

            Destroy(collision.gameObject);
            anim.Play("Santa Death");
            GameManager.instance.GameOver();
            gameOver = true;
        }
    }

}

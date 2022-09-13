using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Examples : MonoBehaviour
{

    Rigidbody2D rb;

    public float speed;

    public SpriteRenderer sprite;

    float xInput;

    int score = 0;

    public Text scoreText;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {

        //Destroy(gameObject,3f);

        //rb.velocity = Vector2.left * speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
        }

        xInput = Input.GetAxis("Horizontal");

        if(xInput < 0)
        {
            sprite.flipX = true;
        }
        else if(xInput > 0)
        {
            sprite.flipX = false;
        }

    }


    private void FixedUpdate()
    {
        rb.velocity = Vector2.right * xInput * speed;
    }


    private void OnMouseDown()
    {
        Destroy(gameObject);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            //Destroy(gameObject);
            Destroy(collision.gameObject);
            score++;

            scoreText.text = score.ToString();

            if(score >= 4)
            {
                //Restart();
                Invoke("Restart",2f);
            }
        }
    }

    void Restart()
    {
        SceneManager.LoadScene("Game");
    }

}

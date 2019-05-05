using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Paint: MonoBehaviour
{
    public float upForce = 200f;
    public float score = 0f;
    public Text scText;
    private bool isDead = false;
    public GameObject gameOver;
    private Rigidbody2D rb2d;               

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isDead == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upForce));
            }
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
        gameOver.SetActive(true);
        
       
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bad" || col.gameObject.tag == "Floor")
        {
            Debug.Log("NOOOOOOOOOO");
            isDead = true;
            gameOver.SetActive(true);

        }
        else
        {
            Debug.Log("It's correct");
            score++;
            scText.text = "Score: " + score;
        }
    }
}

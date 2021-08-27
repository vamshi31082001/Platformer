using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerScript : MonoBehaviour
{
    SpriteRenderer sprite;
    Rigidbody2D rb;
    public float playerSpeed;
    public float jumpVelocity = 5f;
    bool isPlayerGrounded = false;
    Animator anim;
    int coins=0;
    public Text coinstext;
    //GameObject gameObject;

    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isPlayerGrounded = true;
        }
        if (collision.gameObject.tag == "Enemy")
        {
            gameObject.SetActive(false);
            Invoke("RepeatLevel", 0.8f);
        }
        if(collision.gameObject.tag=="FinishFlag")
        {
            Invoke("NextScene", 2.0f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        coins++;
       // coinstext.text = "coins" + coins;
    }

    private void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        if(inputX>0 && isPlayerGrounded == true)
        {
            FlipMovement(false);
            Movement(1);
             anim.SetInteger("State", 1);
           // anim.SetTrigger("run");
            Jump();
        }
        else if(inputX<0 && isPlayerGrounded == true)
        {
            FlipMovement(true);
            Movement(-1);
           // anim.SetTrigger("run");
            anim.SetInteger("State", 1);
            Jump();
        }
        else if(isPlayerGrounded == true)
        {
            //anim.SetTrigger("jump");
            anim.SetInteger("State", 0);
            Jump();
        }
    }

    private void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetInteger("State", 2);
            //rb.velocity = Vector2.up * playerSpeed;
            rb.AddForce(Vector2.up * jumpVelocity);
          //print("jump");
            bool isjump = true;
          //print(isjump);
            if (isjump)
            {
              //print("up arrow");
                transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
                //transform.Translate(-1, 0, 0);
               //sjump = false;
               
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                
                transform.Translate(1, 0, 0);
            }
          isPlayerGrounded = false;
        }
    }

    private void Movement(int x)
    {
        rb.velocity = new Vector2(x, 0) * playerSpeed;
        //rb.AddForce(new Vector2(x,0) * playerSpeed);
    }

    private void FlipMovement(bool value)
    {
        sprite.flipX = value;
    }
    private void RepeatLevel()
    {
        gameObject.SetActive(true);

        SceneManager.LoadScene(0);
    }
    private void NextScene()
    {
        gameObject.SetActive(true);
        SceneManager.LoadScene(2);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    private AudioSource audioSourcePlayer;
    public AudioClip attackSound, jumpSound, potionSound, diamondSound, doorSound;


    public float horizontalMove = 0f;
    public float runSpeed = 40f;
    bool jump = false;
    bool crouch = false;
    private bool death;
    public Rigidbody2D rb;

 

    
    void Start()
    {
        death = false;
        rb = GetComponent<Rigidbody2D>();
        audioSourcePlayer = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            audioSourcePlayer.PlayOneShot(jumpSound);
            animator.SetBool("IsJumping", true);
            jump = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        } else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
        if (Mathf.Abs(horizontalMove) <= 0 && Input.GetKeyDown(KeyCode.Space) && animator.GetBool("IsJumping") == false)
        {
            attack();
        }
    }

    public void isDeath()
    {
        death = true;
        rb.bodyType = RigidbodyType2D.Static;
        animator.SetTrigger("death");
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Potion")
        {
            audioSourcePlayer.PlayOneShot(potionSound);    
        }
        if (collision.tag == "Diamond")
        {
            audioSourcePlayer.PlayOneShot(diamondSound);
        }
        if (collision.tag == "DoorLever")
        {
            audioSourcePlayer.PlayOneShot(doorSound);
        }
    }

    public void attack() 
    {
        animator.SetTrigger("attack");
        audioSourcePlayer.PlayOneShot(attackSound);
    }
}

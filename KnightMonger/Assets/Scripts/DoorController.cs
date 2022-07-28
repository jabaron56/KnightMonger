using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Animator animator;
    private BoxCollider2D doorCollider;
    public GameObject end;
    public AudioSource audioManager;
    public AudioClip endSound;
    private CinemachineVirtualCamera vCam2;
    public LeverController leverController;
    
    void Start()
    {
        animator = GetComponent<Animator>();
        doorCollider = GetComponent<BoxCollider2D>();
    }

    
    void Update()
    {
        
    }

    public void openDoor() 
    {
        animator.SetTrigger("isActiveDoor");
        vCam2.gameObject.SetActive(true);
        FindObjectOfType<PlayerMovement>().rb.bodyType = RigidbodyType2D.Static;
        StartCoroutine("changeCamera2");

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && leverController.doorIsOpen == false && leverController.cameraIsChange == false) 
        {
            leverController.cameraIsChange = true;
            leverController.vCam3.gameObject.SetActive(true);
            StartCoroutine("changeCamera3");
        }
        if (collision.tag == "Player" && leverController.doorIsOpen == true)
        {
            end.SetActive(true);
            Time.timeScale = 0f;
            audioManager.Stop();
            audioManager.PlayOneShot(endSound);
        }
        
    }

    private void Awake()
    {
        vCam2 = GetComponentInChildren<CinemachineVirtualCamera>();
        vCam2.gameObject.SetActive(false);
    }
    IEnumerator changeCamera2()
    {
        yield return new WaitForSeconds(5);
        vCam2.gameObject.SetActive(false);
        FindObjectOfType<PlayerMovement>().rb.bodyType = RigidbodyType2D.Dynamic;
  
    }
    IEnumerator changeCamera3()
    {
        yield return new WaitForSeconds(5);
        leverController.vCam3.gameObject.SetActive(false);
        FindObjectOfType<PlayerMovement>().rb.bodyType = RigidbodyType2D.Dynamic;

    }
}

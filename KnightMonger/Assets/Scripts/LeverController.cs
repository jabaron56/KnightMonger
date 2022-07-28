using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverController : MonoBehaviour

{
    private Animator animator;
    private BoxCollider2D leverCollider;
    public DoorController doorScript;
    public CinemachineVirtualCamera vCam3;
    public bool doorIsOpen = false;
    public bool cameraIsChange = false;

    void Start()
    {
        animator = GetComponent<Animator>();
        leverCollider = GetComponent<BoxCollider2D>();
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            animator.SetTrigger("isActived");
            doorScript.openDoor();
            doorIsOpen = true;
            cameraIsChange = true;
            leverCollider.enabled = false;
        }
    }

    private void Awake()
    {
        vCam3 = GetComponentInChildren<CinemachineVirtualCamera>();
        vCam3.gameObject.SetActive(false);
    }

}

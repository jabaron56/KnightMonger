using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainController : MonoBehaviour
{

    private static int playerLife;
    public PlayerMovement playerMovement;
    private bool isDead = false;
    public Text lifeText;
    
    public GameObject gameOver;

    public Transform playerRespown;
    private Vector3 playerRespownEnd;

    public AudioSource audioManager;
    public AudioClip gameOverSound;


    
    void Start()
    {
        
        playerRespownEnd = playerRespown.position;
        playerLife = 2;
        lifeText.text = "x" + playerLife.ToString();
    }

    
    void Update()
    {
        
        
        lifeText.text = "x" + playerLife.ToString();

    }

    public void upLife()
    {
        if(playerLife < 3)
        {
            playerLife += 1;
        }
    }
    public void downLife()
    {
        if (playerLife > 0)
        {
            if (playerLife == 1)
            {
                playerDie();
            }
            else {
                playerLife -= 1;
                transform.position = playerRespown.position;
            }
        }
    }

    public void playerDie()
    {
        isDead = true;
        playerMovement.isDeath();
        gameOver.SetActive(true);
        StartCoroutine("stopTime");
        audioManager.Stop();
        audioManager.PlayOneShot(gameOverSound);
    }

    IEnumerator stopTime()
    {
        yield return new WaitForSeconds(1);
        Time.timeScale = 0f;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuMonguerController : MonoBehaviour
{
   
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }

    public void Exit()
    {
        Debug.Log("Saliendo...");
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasController : MonoBehaviour
{
   
    void Start()
    {

    }

    
    void Update()
    {
        
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1f;
    }

    public void Salir()
    {
        Application.Quit();
    }
}

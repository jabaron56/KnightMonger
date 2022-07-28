using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionController : MonoBehaviour
{
    public MainController mainController;
    public GameObject potionEffectsPrefab;

    
    void Start()
    {
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Instantiate(potionEffectsPrefab, transform.position, Quaternion.identity);
            mainController.upLife();
            Destroy(gameObject);
        }
    }
}

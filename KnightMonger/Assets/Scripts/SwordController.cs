using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordController : MonoBehaviour
{
    public GameObject enemyEffectsPrefab;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            Instantiate(enemyEffectsPrefab, collision.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }
    }
}

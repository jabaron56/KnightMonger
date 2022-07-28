using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemController : MonoBehaviour
{
    private static int points;
    public Text pointsText;
    public ScoreController scoreController;
    public GameObject diamondEffectsPrefab;
    
    void Start()
    {
        points = 0;
    }

    
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Instantiate(diamondEffectsPrefab, transform.position, Quaternion.identity);
            points += 1;
            pointsText.text = "x" + points.ToString();
            scoreController.addScore(150);
            Destroy(gameObject);

        }
    }
}

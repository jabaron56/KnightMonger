using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform target;
    public float speed;
    private Vector3 start, end;
    private bool facinRight = true;

    
    void Start()
    {
        start = transform.position;
        end = target.position;
    }

    
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        if (transform.position == target.position)
        {
            if (target.position == end)
            {
                target.position = start;
                Flip();
            }
            else
            {
                target.position = end;
                Flip();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        

    }

    void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        facinRight = !facinRight;
    }

}

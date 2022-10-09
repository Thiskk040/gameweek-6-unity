using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    public float speed;
    public Vector3 enemyMoveDirection;
    public float moveDistance;

    private Vector3 startPosition;
    private bool movingTostart;
    

    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (movingTostart)
        {
            transform.position = Vector3.MoveTowards(transform.position, startPosition, speed * Time.deltaTime);

            if (transform.position == startPosition)
            {
                movingTostart = false;

            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, startPosition + enemyMoveDirection * moveDistance, speed * Time.deltaTime);
            if(transform.position == startPosition+ (enemyMoveDirection*moveDistance))
            {
                movingTostart = true;
            }

        }
        
    }
   
}

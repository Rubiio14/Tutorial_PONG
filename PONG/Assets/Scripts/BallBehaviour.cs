using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField]
    GameScoreUI score;
    [SerializeField]
    private Vector3 direction;
    [SerializeField]
    float ballspeed = 1.0f;
    [SerializeField]
    float initialballspeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        //Controla deplazamiento Horizontal
        if(Random.Range(0.0f, 1.0f) < 0.5f)
        {
            Debug.Log("Sucede el 90% de las veces");
            direction = Vector3.right;
        }
        else
        {
            Debug.Log("Sucede el 10% de las veces");
            direction = Vector3.left;
        }
        //Controla deplazamiento vertical
        if(Random.Range(0.0f, 1.0f) < 0.5f)
        {
            Debug.Log("Sucede el 70% de las veces");
            direction += Vector3.up;
        }
        else
        {
            Debug.Log("Sucede el 30% de las veces");
            direction += Vector3.down;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * Time.deltaTime * ballspeed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Una Collision con " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Player"))
        {
            direction.x = -direction.x;
            direction.y = Random.Range(-1f, 1f);
            ballspeed += 0.5f;

        } else if (collision.gameObject.CompareTag("Border"))
        {
            direction.y = -direction.y;
        }
                
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("GoalZoneOne"))
        {
            ResetBall();
            score.GoalPlayerTwo();
        }
        if(collision.CompareTag("GoalZoneTwo"))
        {
            ResetBall();    
            score.GoalPlayerOne();
        }
    }

    void ResetBall()
    {
        /*
        Resetea la pelota a la posicion inicial
        */
        transform.position = Vector3.zero;
        ballspeed = initialballspeed;
        direction.x = -direction.x;
        direction.y = Random.Range(-1f, 1f);
    }

}

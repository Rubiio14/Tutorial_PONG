using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField]
    private Vector3 direction;
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
        transform.position += direction * Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Una Collision con " + collision.gameObject.name);
        {
            if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Border"))
            {
                direction.x = -direction.x;
                direction.y = Random.Range(-1f, 1f);
            }


        }
    }

}

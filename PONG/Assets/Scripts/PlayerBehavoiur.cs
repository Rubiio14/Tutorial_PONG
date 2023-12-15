using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavoiur : MonoBehaviour
{
    [SerializeField]
    KeyCode buttonUp, buttonDown;
    [SerializeField]
    private Vector3 direction;
    [SerializeField]
    float playerspeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(buttonDown))
        {
            direction = Vector3.down;
        }
        else if(Input.GetKey(buttonUp))
        {
            direction = Vector3.up;
        }
        transform.position += direction * Time.deltaTime * playerspeed;
    }
}

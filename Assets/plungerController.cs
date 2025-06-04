using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class plungerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && GetComponent<Transform>().position.y >= -5)
        {
            GetComponent<Rigidbody2D>().linearVelocity = Vector2.down * 50;
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Transform>().position.Set(GetComponent<Transform>().position.x, -5, 0);
        }
    }
}

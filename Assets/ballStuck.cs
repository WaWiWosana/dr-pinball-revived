using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballStuck : MonoBehaviour
{
    public float waitTime = 5f;
    private float timer = 0f;
    public bool stuck = false;

    public GameObject spawner;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            stuck = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            stuck = false;
            timer = 0f;
        }
        
    }
    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            stuck = true;
        }
        if (stuck)
        {
            timer += Time.deltaTime;

        }
        if (timer > waitTime)
        {
            if (other.CompareTag("Ball"))
            {
                other.GetComponent<Transform>().position = spawner.transform.position;
                Debug.Log("Ball Got Stuck");
                timer = 0f;
                stuck = false;
            }
        }
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}

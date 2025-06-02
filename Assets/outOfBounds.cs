using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outOfBounds : MonoBehaviour
{
    public GameObject gm;
    public GameObject skillDoor;
    public bool lifeLost = false;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            GameObject.Destroy(other);
            gm.GetComponent<GameManager>().ballsInPlay -= 1;
            if (gm.GetComponent<GameManager>().ballsInPlay <= 0)
            {
                if (gm.GetComponent<GameManager>().lives > 0)
                {
                    lifeLost = true;
                    skillDoor.SetActive(false);
                }
                else
                {
                    Debug.Log("GAME OVER");
                }
            }
        }

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

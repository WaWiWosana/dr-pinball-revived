using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skillshotdoor : MonoBehaviour
{
    [SerializeField]
    public GameObject door;
    public GameObject oob;
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            door.SetActive(true);
        }
    }

    
    void Update()
    {
        if (oob.GetComponent<outOfBounds>().lifeLost)
        {
            door.SetActive(false);
        }
    }
}

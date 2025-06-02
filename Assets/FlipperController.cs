using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flippercontroller : MonoBehaviour
{
    void Start()
    {
        
    }

    public bool leftFlipper;
    void Update()
    {
        if ((leftFlipper && Input.GetKey(KeyCode.Z)) || (!leftFlipper && Input.GetKey(KeyCode.X)))
        {
            GetComponent<HingeJoint2D>().useMotor = true;
        }
        else
        {
            GetComponent<HingeJoint2D>().useMotor = false;
        }
    }
}

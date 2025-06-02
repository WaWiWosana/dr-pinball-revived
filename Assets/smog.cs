using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class smog : MonoBehaviour
{
    private void OnMouseEnter()
    {
        Destroy(gameObject);
    }
}

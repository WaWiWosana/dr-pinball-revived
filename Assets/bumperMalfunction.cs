using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class bumperMalfunction : MonoBehaviour
{
    public GameObject smog;
    public GameObject gm;
    public int smogWaveAmount = 3;

    private float currentTime = 0;
    public float maxTime = 10;

    public IEnumerator timer()
    {
        resetTimer();
        while (true)
        {
            yield return new WaitForSeconds(1f);
            currentTime++;
            if(currentTime >= maxTime)
            {
                Debug.Log("malfunction!");
                for (int i = 0; i < smogWaveAmount; i++)
                {
                    var position = new Vector3(Random.Range(-5, 5), Random.Range(-5, 16), 0);
                    Instantiate(smog, position, Quaternion.identity);
                    Debug.Log("spawned smog");
                }
                gm.GetComponent<GameManager>().tally += 1;
                resetTimer();
            }
        }
    }


    public void resetTimer()
    {
        currentTime = 0;
    }
    void Start()
    {
        StartCoroutine(timer());
    }
}

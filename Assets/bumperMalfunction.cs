using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class bumperMalfunction : MonoBehaviour
{
    private bool malfunction = false;
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
                malfunction = true;
                Debug.Log("malfunction!");
                for (int i = 0; i < smogWaveAmount; i++)
                {
                    var position = new Vector3(Random.Range(-5, 5), Random.Range(-5, 16), 0);
                    Instantiate(smog, position, Quaternion.identity);
                    Debug.Log("spawned smog");
                }
                gm.GetComponent<GameManager>().tally += 1;
                malfunction = false;
                resetTimer();
            }
        }
    }

    public void smogMalfunction()
    {
        
    }
    public void resetTimer()
    {
        currentTime = 0;
        malfunction = false;
    }
    void Start()
    {
        StartCoroutine(timer());
    }
}

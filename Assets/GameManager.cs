using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.AnimatedValues;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int tally = 0;
    public int lives = 3;
    public int ballsInPlay = 0;
    public int malfGoal = 20;
    [SerializeField]
    private GameObject ballSpawn;
    [SerializeField]
    private GameObject ball;
    [SerializeField]
    private GameObject oOB;

    public void spawnBallLifeLoss()
    {
        Instantiate(ball, ballSpawn.GetComponent<Transform>().position, ballSpawn.GetComponent<Transform>().rotation);
        lives -= 1;
        ballsInPlay += 1;
    }

    public void spawnBallMultiball()
    {
        Instantiate(ball, ballSpawn.GetComponent<Transform>().position, ballSpawn.GetComponent<Transform>().rotation);
        ballsInPlay += 1;
    }
    void Start()
    {
        spawnBallLifeLoss();
    }

    void Update()
    {
        if (oOB.GetComponent<outOfBounds>().lifeLost == true && lives >= 1)
        {
            oOB.GetComponent<outOfBounds>().lifeLost = false;
            spawnBallLifeLoss();
        }
        else if (oOB.GetComponent<outOfBounds>().lifeLost == true)
        {
            Debug.Log("GAME OVER");
        }
    }
}

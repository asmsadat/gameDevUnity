using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    float maxTime;
    float timer;

    public GameObject obstacles1;
    public GameObject obstacles2;
    public GameObject obstacles3;
    public GameObject obstacles4;
    public GameObject obstacles5;
    public GameObject obstacles6;
    public GameObject obstacles7;

    int chooseObstacle;

    // Start is called before the first frame update
    void Start()
    {
        maxTime = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= maxTime)
        {
            GenerateObstacles();
            timer = 0;
        }
    }

    void GenerateObstacles()
    {
        chooseObstacle = Random.Range(1, 8);
        if (chooseObstacle == 1) { GameObject newObstacle = Instantiate(obstacles1); }
        if (chooseObstacle == 2) { GameObject newObstacle = Instantiate(obstacles2); }
        if (chooseObstacle == 3) { GameObject newObstacle = Instantiate(obstacles3); }
        if (chooseObstacle == 4) { GameObject newObstacle = Instantiate(obstacles4); }
        if (chooseObstacle == 5) { GameObject newObstacle = Instantiate(obstacles5); }
        if (chooseObstacle == 6) { GameObject newObstacle = Instantiate(obstacles6); }
        if (chooseObstacle == 7) { GameObject newObstacle = Instantiate(obstacles7); }

    }
}
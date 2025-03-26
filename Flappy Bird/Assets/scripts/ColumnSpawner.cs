using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawner : MonoBehaviour
{
    public GameObject columnPrefab;

    public float minY, maxY;

    float timer;
    public float maxTime;

    // Start is called before the first frame update
    void Start()
    {
        //spawn a column
        SpawnColumn();
    }

    // Update is called once per frame
    void Update()
    {
        //spawn collumns in every x amount of seconds
        timer += Time.deltaTime;
        if(timer >= maxTime)
        {
            SpawnColumn();
            timer = 0;
        }
    }

    void SpawnColumn()
    {
        float randYPos = Random.Range(minY, maxY);

        GameObject newColumn = Instantiate(columnPrefab);
        newColumn.transform.position = new Vector2(
            transform.position.x,
            randYPos);
    }
}

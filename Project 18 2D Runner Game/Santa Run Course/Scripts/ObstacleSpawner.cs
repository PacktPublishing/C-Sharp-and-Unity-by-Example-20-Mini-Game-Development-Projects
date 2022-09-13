using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {

    //public GameObject obstacle;
    public static ObstacleSpawner instance;

    public GameObject[] obstacles;

    public bool gameOver = false;

    public float minSpawnTime, maxSpawnTime;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Use this for initialization
    void Start () {

        StartCoroutine("Spawn");

	}

    IEnumerator Spawn()
    {
        float waitTime = 1f;

        yield return new WaitForSeconds(waitTime);

        while (!gameOver)
        {
            

            SpawnObstacle();

            waitTime = Random.Range(minSpawnTime,maxSpawnTime);

            yield return new WaitForSeconds(waitTime);
        }


    }



    void SpawnObstacle()
    {
        int random = Random.Range(0, obstacles.Length);

        Instantiate(obstacles[random], transform.position, Quaternion.identity);
    }


}

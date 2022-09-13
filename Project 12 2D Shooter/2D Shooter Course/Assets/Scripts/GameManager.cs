using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameObject target;

    public GameObject winText;

    int score = 0;
    public Text scoreText;
    bool win = false;

	// Use this for initialization
	void Start () {

        //Spawn();

        InvokeRepeating("Spawn", 1f, 1f);
    }
	
	// Update is called once per frame
	void Update () {
		
        if( win == true)
        {
            CancelInvoke("Spawn");
        }

        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
        }


	}

    void Spawn()
    {
        float randomX = Random.Range(-7f, 7f);
        float randomY = Random.Range(-3.5f, 3.5f);

        Vector3 randomPosition = new Vector3(randomX, randomY, 0);

        Instantiate(target, randomPosition, Quaternion.identity);
    }

    public void IncrementScore()
    {
        score++;
        print(score);

        scoreText.text = score.ToString();

        if(score >= 10)
        {
            win = true;

            winText.SetActive(true);
        }
    }
}

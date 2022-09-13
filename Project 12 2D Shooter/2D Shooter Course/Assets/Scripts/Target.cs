using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

    public GameManager gameManager;

	// Use this for initialization
	void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        Destroy(gameObject, 2f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnMouseDown()
    {
        gameManager.IncrementScore();

        Destroy(gameObject);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    public float force;


    // Start is called before the first frame update
    void Start()
    {

    }


    private void OnMouseDown()
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().scoreUp();
        Destroy(gameObject);
    }


}

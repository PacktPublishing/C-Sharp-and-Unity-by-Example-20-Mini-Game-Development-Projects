using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraColorChanger : MonoBehaviour
{
    public Color[] colors;
    float timer;
    public float delay;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer>= delay)
        {
            timer = 0;
            ChangeColor();
             
        }

        timer += Time.deltaTime;
    }


    void ChangeColor()
    {
        int rand = Random.Range(0, colors.Length);

        Camera.main.backgroundColor = colors[rand];

    }

}

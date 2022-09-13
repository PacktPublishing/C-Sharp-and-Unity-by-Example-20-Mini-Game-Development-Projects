using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour {

    public int minZoom2D, maxZoom2D;
    public int zoomSpeed2D;

    public int minZoom3D, maxZoom3D;
    public int zoomSpeed3D;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        //2D Camera
        if (Camera.main.orthographic)
        {
            if(Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                //ZoomIn
                Camera.main.orthographicSize -= zoomSpeed2D * Time.deltaTime;
            }
            if(Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                //Zoom out
                Camera.main.orthographicSize += zoomSpeed2D * Time.deltaTime;
            }

            //Restrict The Value
            Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, minZoom2D, maxZoom2D);
        }
        else
        {
            //3D Camera
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                //ZoomIn
                Camera.main.fieldOfView -= zoomSpeed3D * Time.deltaTime;
            }
            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                //Zoom out
                Camera.main.fieldOfView += zoomSpeed3D * Time.deltaTime;
            }

            //Restrict The Value
            Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, minZoom3D, maxZoom3D);

        }

    }
}

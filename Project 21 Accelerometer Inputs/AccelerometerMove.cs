using UnityEngine;
using System.Collections;

public class AccelerometerMove : MonoBehaviour {
	public float speed = 20f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float temp = Input.acceleration.x;
		float z = Input.acceleration.z;
		Debug.Log (temp);
		//transform.Translate (0, 0, -z * speed * Time.deltaTime);
		transform.Rotate (0, 0, -temp * speed);
	}
}

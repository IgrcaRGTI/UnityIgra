using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += transform.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position -= transform.forward;
        }
        if (Input.GetKey(KeyCode.E))
        {
            this.transform.position += transform.right;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            this.transform.position -= transform.right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(new Vector3(0, -1.0f, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(new Vector3(0, 1.0f, 0));
        }
    }
}

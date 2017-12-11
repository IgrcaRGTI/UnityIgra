
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    private Rigidbody rb;
	
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	
	void FixedUpdate ()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");  
        rb.AddForce(new Vector3(moveHorizontal, 0.0f, moveVertical) * speed);
	}
}

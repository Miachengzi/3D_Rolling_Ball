using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
	
	public float speed;
	float x_input;
	float y_input;
	
	Rigidbody rb;
	private void Awake()
	{
		rb = GetComponent<Rigidbody>();
	}
	private void FixedUpdate()
	{
		x_input = Input.GetAxis("Horizontal");
		y_input = Input.GetAxis("Vertical");
		rb.AddForce(x_input * speed, 0, y_input * speed);
	}
	

    // Update is called once per frame
    void Update()
    {
	if(transform.position.y < -5f)
        {
        	SceneManager.LoadScene("SampleScene");
        }
        
    }
}

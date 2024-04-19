using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Ball : MonoBehaviour
{
	int score = 0;
	public int Win = 7;
 
	public float speed;
	float x_input;
	float y_input;

	public TMP_Text scoreText;
	public GameObject YouWin;

	public GameObject Play_again;
	
	Rigidbody rb;
	private void Awake()
	{
		rb = GetComponent<Rigidbody>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Coin")
        	{
         	   	other.gameObject.SetActive(false);
			score++;
            		scoreText.text = score.ToString();
            		if (score == Win)
            		{
                		YouWin.SetActive(true);
				Play_again.SetActive(true);
        		}
		}
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

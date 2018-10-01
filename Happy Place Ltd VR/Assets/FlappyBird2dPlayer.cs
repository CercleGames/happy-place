using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBird2dPlayer : MonoBehaviour {

    Rigidbody2D rb;

    public float jumpPower = 5f;
    public FlappyBird2dSpawner spawner;

    Vector3 startSpot;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        startSpot = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0,jumpPower));

        }


	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "FlappyBird2DObstacle")
        {
            spawner.StartOver();
            transform.position = startSpot;
        }


    }

}

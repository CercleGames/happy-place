using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBird2dObstacle : MonoBehaviour {

    public float moveSpeed = 3f;

    bool hitPlayer = false;

	
	
	// Update is called once per frame
	void Update () {
		
        if (hitPlayer == false)
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
        }



	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "LeftBound")
        {
            Destroy(gameObject);
          
        }
        else if(collision.name == "FlappyBird")
        {
            //give point
           
        }
    }


}

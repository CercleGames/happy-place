using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyMoveScript : MonoBehaviour {

    public float moveSpeed = 25f;



	
	
	// Update is called once per frame
	void Update () {

        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");


        transform.Translate(moveSpeed * xAxis * Time.deltaTime, 0, moveSpeed * yAxis * Time.deltaTime);


	}
}

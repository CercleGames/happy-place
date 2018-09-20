using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiShellScript : MonoBehaviour {

    public float moveSpeed = 15f;

    

	
	
	// Update is called once per frame
	void Update () {


        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");


      //  transform.Translate(xAxis * moveSpeed * Time.deltaTime, 0, yAxis * moveSpeed * Time.deltaTime, Space.World);


        Vector3 euler = transform.localEulerAngles;

       

        float xRot = Mathf.Clamp(yAxis * 15, -25, 25);
        float zRot = Mathf.Clamp(xAxis * 15, -25, 25) * -1;



        euler.x = Mathf.Lerp(euler.x, xRot, 2.0f);
        euler.z = Mathf.Lerp(euler.z, zRot, 2.0f);

        
        transform.localEulerAngles = euler;


	}
}

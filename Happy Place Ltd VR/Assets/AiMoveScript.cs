using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiMoveScript : MonoBehaviour {

    public float moveSpeed = 3f;

    public Transform lookAtTarget;

    public float lookSpeed = 0.1f;
    public float hoverAmount = 1f;
    public float hoverFrequency = 2f;

    public bool lookAt = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");

        float hover = 0;

        if (Mathf.Abs(xAxis) < 0.01 && Mathf.Abs(yAxis) < 0.01)
        {
             hover = hoverAmount * Mathf.Sin(Time.time * hoverFrequency);
        }
            transform.Translate(xAxis * moveSpeed * Time.deltaTime, hover, yAxis * moveSpeed * Time.deltaTime, Space.World);
        

        if (lookAt)
        {

            Vector3 direction = transform.position - lookAtTarget.position;

            Quaternion toRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, toRotation, lookSpeed);
        }
    }
}

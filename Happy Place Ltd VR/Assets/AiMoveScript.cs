using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiMoveScript : MonoBehaviour {

    public float moveSpeed = 3f;

    public Transform lookAtTarget;

    public float lookSpeed = 0.1f;
    public float hoverAmount = 1f;
    public float hoverFrequency = 2f;

    Rigidbody rb;
    public Transform GoPoint;
    Vector3 targetPoint;

    public bool lookAt = false;
    bool isMoving;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        targetPoint = transform.position;
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown(KeyCode.Space))
        {

            MoveAI(GoPoint, moveSpeed);

        }



        if (isMoving == false)
        {
            float hover = 0;
            hover = hoverAmount * Mathf.Sin(Time.time * hoverFrequency);
            transform.Translate(0, hover, 0, Space.World);
        }

      



        if (lookAt)
        {

            Vector3 direction = transform.position - lookAtTarget.position;

            Quaternion toRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, toRotation, lookSpeed);
        }
    }


    public void MoveAI(Transform moveTo, float seconds)
    {
        StartCoroutine(SmoothMove(moveTo.position, seconds));
    }

    IEnumerator SmoothMove(Vector3 endpos, float seconds)
    {
        isMoving = true;
        float t = 0.0f;
        Vector3 startpos = transform.position;
        while (t <= 1.0)
        {
            t += Time.deltaTime / seconds;
            rb.MovePosition(Vector3.Lerp(startpos, endpos, Mathf.SmoothStep(0.0f, 1.0f, Mathf.SmoothStep(0.0f, 1.0f, t))));
            yield return null;
            
        }
        isMoving = false;
    }

}

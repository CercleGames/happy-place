using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiShellScript : MonoBehaviour {

    Rigidbody rb;
    Vector3 lastPos;

   public float tiltAmount = 25;

    private void Start()
    {
        rb = GetComponentInParent<Rigidbody>();
        lastPos = transform.position;
    }



    // Update is called once per frame
    void Update () {

        Vector3 currentPos = transform.position - lastPos;

        float xAxis = currentPos.x;
        float yAxis = currentPos.z;
        print(currentPos);


      


        Vector3 euler = transform.localEulerAngles;

       

        float xRot = Mathf.Clamp(yAxis * tiltAmount, -25, 25);
        float zRot = Mathf.Clamp(xAxis * tiltAmount, -25, 25) * -1;



        euler.x = Mathf.Lerp(euler.x, xRot, 2.0f);
        euler.z = Mathf.Lerp(euler.z, zRot, 2.0f);

        
        transform.localEulerAngles = euler;

        lastPos = transform.position;
	}
}

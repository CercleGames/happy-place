using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiGyroScript : MonoBehaviour {

    public float spinSpeedX = 5f;
    public float spinSpeedY = 5f;
    public float spinSpeedZ = 0f;
	
	// Update is called once per frame
	void Update () {


        

        transform.Rotate(spinSpeedX,spinSpeedY, spinSpeedZ, Space.Self);
        

	}
}

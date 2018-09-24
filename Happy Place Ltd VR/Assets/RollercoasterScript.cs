using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollercoasterScript : MonoBehaviour {


    Animator anim;
    public float speedMultipler = 2f;
    public float ease = .01f;

    float speed;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        float yAxis = Input.GetAxis("Vertical");

        speed = Mathf.Lerp(yAxis, speed, ease);

        anim.SetFloat("Speed", speed);

	}
}

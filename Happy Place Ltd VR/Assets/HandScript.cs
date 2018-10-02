using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class HandScript : MonoBehaviour {


    public VRTK_AvatarHandController handController;
    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update() {


        if (handController.controllerEvents.triggerPressed && anim.GetBool("TriggerPressed") == false)
        {
            anim.SetBool("TriggerPressed", true);

        } else if(handController.controllerEvents.triggerPressed == false && anim.GetBool("TriggerPressed") == true)
        {
            anim.SetBool("TriggerPressed", false);
        }
    }

	
}

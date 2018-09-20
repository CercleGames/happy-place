using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RedButtonLearn : MonoBehaviour {

    bool isGreen = false;

    public Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGreen = !isGreen;

        if(isGreen)
        rend.material.color = Color.green;
        else
        {
            rend.material.color = Color.red;
        }
    }



}

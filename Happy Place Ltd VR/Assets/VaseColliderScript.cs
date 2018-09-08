using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaseColliderScript : MonoBehaviour {

    public VaseScript vaseScript;

    bool hasBroken = false;
    public VaseSpawn spawn;

    public float radius = 5f;
    public float force = 300;
    public GameObject forcePoint;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "bat" && hasBroken == false)
        {
            hasBroken = true;
            vaseScript.BreakTheVase(gameObject);
          Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

            foreach (Collider nearbyObject in colliders)
            {
               Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
                if(rb != null)
                {
                    rb.AddExplosionForce(force, forcePoint.transform.position, radius);
                }
            }

            
        }
    }


   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaseSpawn : MonoBehaviour {

    public GameObject vase;

    public float vaseForce = 250f;

    public void SpawnVaseNow()
    {
        Invoke("Spawn", 2);
    }

 public   void Spawn()
    {
        GameObject clone = Instantiate(vase, transform.position, Quaternion.identity) as GameObject;
        clone.GetComponentInChildren<Rigidbody>().AddForce(transform.forward * vaseForce);
        // Destroy(clone, 3);
    }

}

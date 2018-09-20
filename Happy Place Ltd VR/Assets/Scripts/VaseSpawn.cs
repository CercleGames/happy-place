using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaseSpawn : MonoBehaviour {

    public GameObject vase;

    public void SpawnVaseNow()
    {
        Invoke("Spawn", 2);
    }

    void Spawn()
    {
        GameObject clone = Instantiate(vase, transform.position, Quaternion.identity);
        Destroy(clone, 3);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaseScript : MonoBehaviour {

    public GameObject brokenVase;

    

    public void BreakTheVase(GameObject original)
    {
       GameObject clone = Instantiate(brokenVase, original.transform.position, original.transform.rotation);
        Destroy(clone, 3);
        

        Destroy(gameObject);

    }


	
}

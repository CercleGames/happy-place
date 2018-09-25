using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Controllables;

public class RedButtonLearn : MonoBehaviour {

   
    public VRTK_BaseControllable pusher;

    public VaseSpawn vaseSpawn;

    private void Update()
    {
        if (pusher.AtMaxLimit())
        {
            print("button pushed");
            vaseSpawn.Spawn();

        }
    }





}

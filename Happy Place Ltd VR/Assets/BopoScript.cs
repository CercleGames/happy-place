using UnityEngine;

public class BopoScript : MonoBehaviour {

    public AudioClip[] squeaks;
    [Space]
    public AudioClip[] compliments;


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Hands")
        {
            //stop audio
            //play one random squeak
            //play one random message
        }
    }
}

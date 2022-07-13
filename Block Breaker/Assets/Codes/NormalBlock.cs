using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBlock : MonoBehaviour
{
    
    AudioSource audio;
    
      private void Start() {
        audio = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision coll)
    {
        if(coll.collider.tag == "Ball")
        {
            Destroy(gameObject);
             
        }
        audio.Play();
    }
   
}

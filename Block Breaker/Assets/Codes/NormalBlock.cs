using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NormalBlock : MonoBehaviour
{
    
   // AudioSource audio;
    public UnityEvent OnCollisionEvent;
    
      private void Start() {
        //audio = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision coll)
    {
        if(coll.collider.tag == "Ball")
        {
            Destroy(gameObject);
             
        }
        OnCollisionEvent?.Invoke();
        //audio.Play();
    }
   
}

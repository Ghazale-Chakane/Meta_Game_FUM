using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NormalBlock : MonoBehaviour
{
    
    public UnityEvent OnCollisionEvent;
    public CameraShake CameraShake;
    
      private void Start() {
        //audio = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision coll)
    {
        if(coll.collider.tag == "Ball")
        {
            OnCollisionEvent?.Invoke();
            StartCoroutine(CameraShake.shake(.15f, .4f));
            Destroy(gameObject);
             
        }
        
        //audio.Play();
    }
   
}

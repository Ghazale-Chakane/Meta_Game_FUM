using UnityEngine;
using UnityEngine.Events;

public class TwoTimesDestroy : MonoBehaviour
{
    private bool breaker = false;
    AudioSource audio;
    public UnityEvent OnCollisionEvent;
    public CameraShake CameraShake;
    
    private void Start() {
        audio = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.tag == "Ball")
        {
            if (!breaker)
            {
                breaker = true;
            }
            else
            {
                OnCollisionEvent?.Invoke();
                Destroy(gameObject);
            }
        }
        audio.Play();
        StartCoroutine(CameraShake.shake(.15f, .4f));
    }
}

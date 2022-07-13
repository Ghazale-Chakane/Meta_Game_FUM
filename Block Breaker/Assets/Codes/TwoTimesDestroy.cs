using UnityEngine;

public class TwoTimesDestroy : MonoBehaviour
{
    private bool breaker = false;
     AudioSource audio;
    
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
                Destroy(gameObject);
            }
        }
        audio.Play();
    }
}

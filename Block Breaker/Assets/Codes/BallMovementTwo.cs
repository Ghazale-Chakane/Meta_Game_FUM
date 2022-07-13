using UnityEngine;
using UnityEngine.Events;

public class BallMovementTwo : MonoBehaviour
{
    public Rigidbody rb;
    private float speed = 20.0f;
    public UnityEvent OnCollisionEvent;
    void Start()
    {
        rb.AddForce(-250, 0, -500);
    }
      private void Update() {
          Vector3 v = GetComponent<Rigidbody>().velocity;
           v = v.normalized;
           v *= speed;
           GetComponent<Rigidbody>().velocity = v;
    }
    private void OnCollisionEnter(Collision other) {
        OnCollisionEvent?.Invoke();
    }
    
}

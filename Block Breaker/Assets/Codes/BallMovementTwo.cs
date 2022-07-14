using UnityEngine;
using UnityEngine.Events;

public class BallMovementTwo : MonoBehaviour
{
    public Rigidbody rb;
    private float speed = 20.0f;
    public UnityEvent OnCollisionEvent;
    void Start()
    {
        rb.AddForce(-300, 0, -500);
    }
    private void Update() {
        Vector3 v = GetComponent<Rigidbody>().velocity;
        v = v.normalized;
        v *= speed;
        GetComponent<Rigidbody>().velocity = v;
        if(transform.position.x >= 16)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision other) {
        OnCollisionEvent?.Invoke();
    }
    
}

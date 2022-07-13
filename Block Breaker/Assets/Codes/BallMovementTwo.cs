using UnityEngine;

public class BallMovementTwo : MonoBehaviour
{
    public Rigidbody rb;
    private float speed = 13.0f;
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
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle_Movement : MonoBehaviour
{
  Vector3 position;
    private const float Paddle_Speed = 30f;

    void Start() {
        position = transform.position;
    }

     private void Update() {
        float movez = Input.GetAxis ("Horizontal");
        position.z += movez * Time. deltaTime * Paddle_Speed;
        position.z = Mathf.Clamp (position.z,-13.8f,+13.8f);
        transform.position = position;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_Movement : MonoBehaviour{

    public Rigidbody rb;
    public bool inplay;
    public Transform Paddle;
    public float speed;

    void Start(){
        rb = GetComponent<Rigidbody> ();
    }

    void Update(){
       if(!inplay){
        transform.position = Paddle.position;
       }
       if(Input.GetButtonDown("Jump") && !inplay){
        inplay = true;
        rb.AddForce(Vector3.forward * speed);
        rb.AddForce(Vector3.right * speed);
        rb.AddForce(Vector3.left * speed);

       }

        }
         private void OnTriggerEnter(Collider other){
            rb.velocity = Vector3.zero;
            inplay = false;
         }
/*
   private float ballSpeed = 10f;
   private bool dirx;
   private bool dirz;
   private float leftpos = -9.6f;
   private float rightpos = 9.6f; 
    void Start(){
       dirx = true;
       dirz = true;
    }

    void Update(){
        if(dirx==true && dirz==true){
            transform.position = new Vector3(transform.position.x-(ballSpeed * Time. deltaTime), transform.position.y,transform.position.z-(ballSpeed * Time. deltaTime));

        }
           if(dirx==true && dirz==false){
            transform.position = new Vector3(transform.position.x-(ballSpeed * Time. deltaTime), transform.position.y,transform.position.z+(ballSpeed * Time. deltaTime));
            
        }
          
    if(dirx==false && dirz==true){
            transform.position = new Vector3(transform.position.x+(ballSpeed * Time. deltaTime), transform.position.y,transform.position.z-(ballSpeed * Time. deltaTime));
            
        }   
        if(dirx==false && dirz==false){
            transform.position = new Vector3(transform.position.x+(ballSpeed * Time. deltaTime), transform.position.y,transform.position.z+(ballSpeed * Time. deltaTime));
            
        }
}
 private void OnTriggerEnter(Collider other) {
    if(other.tag == "UpBoarder"){
        dirz = true;
    }
     if(other.tag == "LeftBoarder"){
        dirx = false;
    }
     if(other.tag == "RightBoarder"){
        dirx = true;
    }
     if(other.tag == "DownBoarder"){
        transform.position = new Vector3(0,0.6f,0);
        dirx = true;
        dirz = true;
    }
    if(other.tag == "Paddle"){
        dirz= false;
    }
}
}
*/
}


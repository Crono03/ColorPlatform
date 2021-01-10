using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    private float jumpVelocity;

    void Start(){

        rb= GetComponent<Rigidbody2D>();
}
   void Update(){
     bool jump= Input.GetKeyDown(KeyCode.Space);
      if(jump)
     {
      jumpVelocity=5;
     }
      else jumpVelocity=0;
     Vector2 moveInput=new Vector2(Input.GetAxis("Horizontal"),jumpVelocity);
     moveVelocity=moveInput * speed;
   }
   void FixedUpdate(){

     rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
   }
}

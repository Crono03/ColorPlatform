using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    enum GravityDirection { Down, Left, Up, Right };
    GravityDirection m_GravityDirection;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    private float jumpVelocity;

    void Start(){
        m_GravityDirection = GravityDirection.Down;
        rb= GetComponent<Rigidbody2D>();
}
   void Update(){

     bool jump= Input.GetKeyDown(KeyCode.Space);
     if(jump){
    jumpVelocity=0.2f;
    GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpVelocity), ForceMode2D.Impulse);
  }
     Vector2 moveInput=new Vector2(Input.GetAxis("Horizontal"),jumpVelocity);
     moveVelocity=moveInput * speed;
   }
   void FixedUpdate(){
     rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
   }
}

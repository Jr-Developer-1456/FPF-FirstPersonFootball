using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidingShootStuff : MonoBehaviour
{
    public Rigidbody ballRigidBody;
    public float ShootingSpeed = 17f;
    public float moveForce = 10f;
    public float upwardModifier = 10f;
    void Start()
    {
        if (ballRigidBody == null)
        {
            ballRigidBody = GetComponent<Rigidbody>();
        }
    }
    void Update(){
        //ShootUp();
    }
    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector3 moveForward = collision.transform.forward;
            ballRigidBody.AddForce(moveForward * ShootingSpeed, ForceMode.Impulse);
        }

    }
    //void OnCollisionEnter(Collision collision){
    //void ShootUp(){
    //if(/*Input.GetKey(KeyCode.Q)&&*/ Input.GetButton("Fire1")){
    //    if (gameObject.CompareTag("Player"))
    //    {
    //        Vector3 lookDirection = gameObject.transform.forward;
    //        Vector3 forceDirection = (lookDirection + Vector3.up * upwardModifier).normalized;
    //        ballRigidBody.AddForce(forceDirection * moveForce, ForceMode.Impulse);
    //        Debug.Log("Ball collided with player and moved in the direction the player is looking at, with an upward force!");
    //    }
    //    Debug.Log("Got the Key but no Collision");
    //  }
    //}
}
    //}

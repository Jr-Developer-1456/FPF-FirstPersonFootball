using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalStuff : MonoBehaviour
{
    public float Score;
    public Rigidbody BallRigidBody;
    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("FootBall"))
        {
            collision.transform.position=new Vector3(0,1,0);
            Score++;
        }
        Debug.Log("The Score is: "+Score);


    }
}

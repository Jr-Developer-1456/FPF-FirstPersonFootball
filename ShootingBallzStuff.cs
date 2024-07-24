using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class ShootingBallzStuff : MonoBehaviour
{
    [Header("Player & Ball Property")]                                                                                                                                                                                                             
    public GameObject ballGameObject;
    public Rigidbody ballRigidbody;
    public GameObject player;
    public float shootingForce = 37f;
    public float shootingDistance = 1.5f;


    void Start()
    {
        if (ballRigidbody == null)
        {
            ballRigidbody = ballGameObject.GetComponent<Rigidbody>();
        }

    }

    void Update()
    {
        DistanceForForce();   
    }
    void DistanceForForce()
    {
        float distance = Vector3.Distance(ballRigidbody.position, player.transform.position);

        if (distance <= shootingDistance && Input.GetButtonDown("Fire1"))
        {
            Vector3 moveForward = transform.forward;
            ballRigidbody.AddForce(moveForward * shootingForce, ForceMode.Impulse);
        }
    }

}

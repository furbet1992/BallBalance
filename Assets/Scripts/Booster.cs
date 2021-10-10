using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    public BallMovement ballSpeedControl; 


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            ballSpeedControl.moveSpeed = 10f; 
        }
    }






}

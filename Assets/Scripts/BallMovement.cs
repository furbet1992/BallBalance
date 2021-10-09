using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isFlat = true;
    private Rigidbody rb;

    Vector3 forcecVec;
    public float moveSpeed = 20f; 

    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tilt = Input.acceleration;

        if (isFlat)
        {
            tilt = Quaternion.Euler(90, 0, 0) * tilt;
        }

        rb.AddForce(tilt * 5);
        Debug.DrawRay(transform.position + Vector3.up, tilt, Color.blue);

        //rb.AddForce(Input.gyro.userAcceleration.x * forcecVec);
       
    }

}

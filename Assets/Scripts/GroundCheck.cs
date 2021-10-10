using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{

    [SerializeField] private LayerMask platformLayerMask;

    public bool isGrounded; 

    private void OnTriggerEnter(Collider other)
    {
       
    }




}

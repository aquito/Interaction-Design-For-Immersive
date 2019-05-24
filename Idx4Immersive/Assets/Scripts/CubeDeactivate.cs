using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDeactivate : MonoBehaviour
{
    // Vector3 resetDirection;

    private void Start() {
       // resetDirection = new Vector3();
    }
    private void OnTriggerEnter(Collider other) {
        
        if(other.gameObject.tag == "cube")
        {
            other.gameObject.SetActive(false); // sending cube back to the pool
           
        }
    }

    
}

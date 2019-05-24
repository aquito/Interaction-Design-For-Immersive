using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saber : MonoBehaviour
{
        public float strikeForce;

     private void OnTriggerEnter(Collider other) { // add box collider to cubes as trigger if the other solution doesn't work!

        if(other.gameObject.tag == "cube")
        {
            other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            other.gameObject.GetComponent<Rigidbody>().AddForce(this.transform.forward * strikeForce); 
        }
        
    }
}

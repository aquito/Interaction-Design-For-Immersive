using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flight : MonoBehaviour
{
    public Vector3 velocity;
    
    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {
        this.transform.Translate(velocity);
    }

  

    private void OnCollisionEnter(Collision other) {

        if(other.gameObject.tag == "stopper")
        {
            this.gameObject.SetActive(false);
            Debug.Log("Cube hit back stopper");
        }
        else if(other.gameObject.tag == "saber")
        {
            this.gameObject.GetComponent<Hit>().HitEffect();
        }
    
    }

  

}

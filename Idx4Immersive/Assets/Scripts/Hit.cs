using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    
    AudioSource audioSource;    // Start is called before the first frame update
    void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();

    }


    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    void OnCollisionEnter(Collision other)
    {

        if(other.gameObject.tag == "saber")
        {
            Debug.Log("Cube was hit with saber");
            this.gameObject.GetComponent<Rigidbody>().useGravity = true;
            HitEffect();
        }
    
    }

   
    
    

    public void HitEffect()
    {
        audioSource.Play();
       // this.gameObject.SetActive(false);
        
        
    }
}

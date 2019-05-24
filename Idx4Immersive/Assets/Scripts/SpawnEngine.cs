using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEngine : MonoBehaviour
{
    
    public GameObject cube;

    Vector3 resetDirection;


    public bool onBeat;
    
    // Start is called before the first frame update
    void Start()
    {
        onBeat = false;
        resetDirection = new Vector3();
              
    }

    // Update is called once per frame
    void Update()
    {
        if(onBeat)
        {
            //Instantiate(cube, this.transform.position, Quaternion.identity);
            
            GameObject cube = Pool.singleton.Get("cube");
            

            if(cube != null)
            {
                cube.transform.position = this.transform.position;
                resetDirection = cube.gameObject.GetComponent<Flight>().velocity;
                cube.gameObject.GetComponent<Transform>().forward = -resetDirection;
                cube.GetComponent<Rigidbody>().isKinematic = true;
                cube.SetActive(true);

                onBeat = false;
            }
            
        }  
       
    }
}

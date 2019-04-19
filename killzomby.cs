using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class killzomby : MonoBehaviour {
    private GameObject zombie;
   

    private bool reloading =false;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "zomby")
        {
            Destroy(collision.gameObject);
           // zombie = GameObject.FindGameObjectWithTag("zomby");
            
           // Destroy(zombie);
            

            Manager.scoreint++;
            Destroy(this.gameObject);
        }
        
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderShield : MonoBehaviour{
    public SingelPlayerGame game; 

    // Detect Shield collision
    void OnTriggerEnter(Collider other) {
        //string objectName = transform.parent.gameObject.name;
        //Debug.Log("Object name: " + objectName);
        if(transform.parent.gameObject.name == "Bullet") {
            transform.parent.gameObject.SetActive(false); // Deactivate the parent object 
            Invoke("ReactivateObject", 5f); // Reactivate the object after 5 seconds
            game.addBullets(5); // Add 5 bullets   
        } else { // is shield  
            //game.
        }
    }

    void ReactivateObject() {
        transform.parent.gameObject.SetActive(true);
    }
}

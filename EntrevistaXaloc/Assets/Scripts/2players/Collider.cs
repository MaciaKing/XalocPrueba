using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour{

    public Game2 game; 

    // Detect Shield collision
    void OnTriggerEnter(Collider other) {
        Debug.Log("Collision +++++++");
       /* if(transform.gameObject.name == "Player1") {
            
            //transform.gameObject.SetActive(false); // Deactivate the parent object 
            //Invoke("ReactivateObject", 5f); // Reactivate the object after 5 seconds
            //game.addBullets(5); // Add 5 bullets   
        } else{
            //game.addCactusShot(); // Add 1 cactus
            //Destroy(transform.gameObject); //Delate the cactus
        }*/
    }

    void ReactivateObject() {
        transform.gameObject.SetActive(true);
    }
}

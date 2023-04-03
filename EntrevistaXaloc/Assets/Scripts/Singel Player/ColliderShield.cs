using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderShield : MonoBehaviour{

    public SingelPlayerGame game; 

    // Find the 'game' object in the hierarchy if it is null
    void Start() {
        if (game == null) {
            GameObject gameObj = GameObject.Find("Game1");
            if (gameObj != null) {
                game = gameObj.GetComponent<SingelPlayerGame>();
            }
        }
    }

    // Detect Shield collision
    void OnTriggerEnter(Collider other) {
        if(transform.gameObject.name == "Bullet") {
            transform.gameObject.SetActive(false); // Deactivate the parent object 
            Invoke("ReactivateObject", 5f); // Reactivate the object after 5 seconds
            game.addBullets(5); // Add 5 bullets   
        } else if (transform.gameObject.name=="Cactus Variant(Clone)"){ // is shield  
            game.addCactusShot(); // Add 1 cactus
            Destroy(transform.gameObject); //Delate the cactus
        }
    }

    void ReactivateObject() {
        transform.gameObject.SetActive(true);
    }
}

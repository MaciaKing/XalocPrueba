using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderShield : MonoBehaviour{

    public SingelPlayerGame game; 

    // Buscar el objeto 'game' en la jerarquía si es nulo
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
            Debug.Log("HE ENTRAAADOOOOOO soy : " + transform.gameObject.name + "ha chocado : " + other.gameObject.name);
            game.addCactusShot(); // Add 1 cactus
            //Delate the cactus
            Destroy(transform.gameObject); // ESTA LINEA NO FUNCIONA
        }
    }

    void ReactivateObject() {
        transform.gameObject.SetActive(true);
    }
}

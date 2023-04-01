using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SingelPlayerGame : MonoBehaviour{
   
    public CanvasManager canvasManager;
    public GameObject cactus;
    public GameObject plane;
    public int bullets = 10;
    public int shield = 0;

    private int maxBullets = 15;
    private int maxShield = 1;

    void Start(){
        // spawn cactus
        for (int i = 0; i < 4; i++){
            spawnCactus();
        }
    }

    void Update(){
        //update bullets and shield
        canvasManager.setBullets(bullets.ToString());
        canvasManager.setShield(shield.ToString());
    }

    // Add bullets
    public void addBullets(int bullets){
        int aux = this.bullets + bullets;
        if (aux >= maxBullets){
            this.bullets = maxBullets;
        } else{
            this.bullets += aux;
        }
    }

    // Add shield
    public void addShield(int shield){
        if (this.shield <= maxShield){
            this.shield = 1;
        }
    }

    // Generate random cactus position
    private void spawnCactus(){
        float x = Random.Range(-45f, 45f);
        float z = Random.Range(-45f, 45f);
        Vector3 pos = new Vector3(x, 0f, z);
        GameObject newCactus = Instantiate(cactus, pos, Quaternion.identity);
    }

}

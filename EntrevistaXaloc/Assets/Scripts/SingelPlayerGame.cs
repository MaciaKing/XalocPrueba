using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SingelPlayerGame : MonoBehaviour{
   
    public CanvasManager canvasManager;
    public GameObject cactus;
    public GameObject plane;
    public int bullets = 10;
    public int nCactus = 0;
    private int maxNcactus = 1;

    private int maxBullets = 15;
    private int maxShield = 1;

    public GameObject bullet;
    public Transform spawnBullet; 
    public float shotForce = 0.1f;
    public float shotRate = 0.5f;
    public float shoteRateTime = 0f;

    private float startTime;

    void Start(){
        canvasManager.hideFinal();
        startTime = Time.time;
        // spawn cactus
        for (int i = 0; i < 4; i++){
            spawnCactus();
        }
    }

    void Update(){
        //if the game is end
        if (nCactus >= maxNcactus){
            float elapsedTime = Time.time - startTime;
            canvasManager.setTime(elapsedTime.ToString());
            canvasManager.hideCanvas();
            Time.timeScale = 0;
        }

        // shot
        if (Input.GetKeyDown(KeyCode.Space)){
            shot();
        }
        //update bullets and shield
        canvasManager.setBullets(bullets.ToString());
        canvasManager.setCactues(nCactus.ToString());
    }

    // aplica sumador cactus
    public void addCactusShot(){
        nCactus++;
        canvasManager.setCactues(nCactus.ToString());
        //Spawn un altre cactus
        spawnCactus();
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

    // Generate random cactus position
    private void spawnCactus(){
        float x = Random.Range(-45f, 45f);
        float z = Random.Range(-45f, 45f);
        Vector3 pos = new Vector3(x, 0f, z);
        GameObject newCactus = Instantiate(cactus, pos, Quaternion.identity);
    }
    
    // Shot tank
    private void shot(){
        if (bullets > 0){
            if(Time.time > shoteRateTime){
              bullets--;
              GameObject newBullet = Instantiate(bullet, spawnBullet.position, spawnBullet.rotation);
              newBullet.AddComponent<Bullet>().speed = shotForce / newBullet.GetComponent<Rigidbody>().mass;
              //Debug.DrawRay(spawnBullet.position, spawnBullet.forward * 10f, Color.black, 4f);
              shoteRateTime = Time.time + shotRate;
              Destroy(newBullet, 2f);
        }
    }

}

}

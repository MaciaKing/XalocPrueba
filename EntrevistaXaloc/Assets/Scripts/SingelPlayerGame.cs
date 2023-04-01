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

    public GameObject bullet;
    public Transform spawnBullet; 
    public float shotForce = 15000f;
    public float shotRate = 0.5f;
    public float shoteRateTime = 0f;

    void Start(){
        // spawn cactus
        for (int i = 0; i < 4; i++){
            spawnCactus();
        }
    }

    void Update(){
        // shot
        if (Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("Space pressed DISPAAAROOOOO");
            shot();
        }
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
    
    private void shot(){
        if (bullets > 0){
            if(Time.time > shoteRateTime){
                bullets--;
                //GameObject newBullet = Instantiate(bullet, spawnBullet.position, spawnBullet.rotation);
                //newBullet.GetComponent<Rigidbody>().AddForce(spawnBullet.forward * shotForce);
                GameObject newBullet = Instantiate(bullet, spawnBullet.position, spawnBullet.rotation);
                newBullet.GetComponent<Rigidbody>().AddForce(spawnBullet.forward * shotForce);
                Debug.DrawRay(spawnBullet.position, spawnBullet.forward * 10f, Color.black, 4f);

                shoteRateTime = Time.time + shotRate;
                Destroy(newBullet, 2f);
            }
           
            
        }
    }
}

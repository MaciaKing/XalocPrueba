using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Game2 : MonoBehaviour{
   
    public CanvasManager2 canvasManager;
    public int bullets_1 = 10;
    public int bullets_2 = 10;

    private int maxBullets = 15;
    private int maxShield = 1;

    public GameObject bullet;
    public Transform spawnBulletPlayer1;
    public Transform spawnBulletPlayer2; 
    public float shotForce = 0.1f;
    public float shotRate = 0.5f;
    public float shoteRateTime = 0f;

    private float startTime;
    private bool endGame = false;

    void Start(){
        canvasManager.hideFinal();
        startTime = Time.time;
    }

    void Update(){

        if (endGame){
            Debug.Log("End Game");
        }

        // shot
        if (Input.GetKeyDown(KeyCode.Space)){
            shot(1);
        }
        
        if (Input.GetKeyDown(KeyCode.L)){
            shot(2);
        }
        //update bullets and shield
        canvasManager.setBullets1(bullets_1.ToString());
        canvasManager.setBullets2(bullets_2.ToString());
        
    }


    // Add bullets
    public void addBullets(int bullets){
    int aux = this.bullets_1 + bullets;
    if (aux >= maxBullets){
        this.bullets_1 = maxBullets;
    } else{
        this.bullets_1 = aux;
    }
}


    
    // Shot tank
    private void shot(int player){
        if(player == 1){
            if (bullets_1 > 0){
                if(Time.time > shoteRateTime){
                  bullets_1--;
                  GameObject newBullet = Instantiate(bullet, spawnBulletPlayer1.position, spawnBulletPlayer1.rotation);
                  newBullet.AddComponent<Bullet>().speed = shotForce / newBullet.GetComponent<Rigidbody>().mass;
                    //Debug.DrawRay(spawnBullet.position, spawnBullet.forward * 10f, Color.black, 4f);
                  shoteRateTime = Time.time + shotRate;
                  Destroy(newBullet, 2f);
                }
            }
        } else{ // player 2
            if (bullets_2 > 0){
                if(Time.time > shoteRateTime){
                  bullets_2--;
                  GameObject newBullet = Instantiate(bullet, spawnBulletPlayer2.position, spawnBulletPlayer2.rotation);
                  newBullet.AddComponent<Bullet>().speed = shotForce / newBullet.GetComponent<Rigidbody>().mass;
                    //Debug.DrawRay(spawnBullet.position, spawnBullet.forward * 10f, Color.black, 4f);
                  shoteRateTime = Time.time + shotRate;
                  Destroy(newBullet, 2f);
                }
            }
        }

}

}

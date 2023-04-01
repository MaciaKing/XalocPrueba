using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SingelPlayerGame : MonoBehaviour
{
    public CanvasManager canvasManager;
    public int bullets = 10;
    public int shield = 10;

    void Update(){
        //update bullets and shield
        canvasManager.setBullets(bullets.ToString());
        canvasManager.setShield(shield.ToString());
    }

}

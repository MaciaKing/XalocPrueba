using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour{
    public Text textBullets;  // Text for number of bales
    public Text textShield;   // Text for number of shields

    // Setters
    public void setBullets(string bullets){
        textBullets.text = bullets;
    }

    // Setters
    public void setShield(string shield){
        textShield.text = shield;
    }
}

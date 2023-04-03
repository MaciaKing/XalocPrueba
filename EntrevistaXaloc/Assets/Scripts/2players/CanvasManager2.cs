using UnityEngine;
using UnityEngine.UI;

public class CanvasManager2 : MonoBehaviour{
    public Image imageBullets; // Image for number of bales
    public Text textBullets;  // Text for number of bales
    public Image imageShield;  // Image for number of shields
    public Text textShield;   // Text for number of shields
    public Image imageBullets_2; // Image for number of bales
    public Text textBullets_2;  // Text for number of bales
    public Image imageShield_2;  // Image for number of shields
    public Text textShield_2;   // Text for number of shields
    public Text label;
    public Text winner;

    // Ocultar label finals
    public void hideFinal(){
        label.gameObject.SetActive(false);
        winner.gameObject.SetActive(false);
    }

    // Ocultar Canvas  
    public void hideCanvas(){
        //gameObject.SetActive(false);
        textBullets.gameObject.SetActive(false);
        imageBullets.gameObject.SetActive(false);
        textShield.gameObject.SetActive(false);
        imageShield.gameObject.SetActive(false);

        textBullets_2.gameObject.SetActive(false);
        imageBullets_2.gameObject.SetActive(false);
        textShield_2.gameObject.SetActive(false);
        imageShield_2.gameObject.SetActive(false);

        //show label final
        label.gameObject.SetActive(true);
    }

    // Setters
    public void setBullets1(string bullets){
        textBullets.text = bullets;
    }

    public void setBullets2(string bullets){
        textBullets_2.text = bullets;
    }
}

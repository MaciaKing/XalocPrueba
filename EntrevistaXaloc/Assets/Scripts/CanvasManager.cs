using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour{
    public Image imageBullets; // Image for number of bales
    public Text textBullets;  // Text for number of bales
    public Image imageCactus;  // Image for number of shields
    public Text textCactus;   // Text for number of shields
    public Text label;
    public Text time;

    // Ocultar label finals
    public void hideFinal(){
        label.gameObject.SetActive(false);
        time.gameObject.SetActive(false);
    }

    // Ocultar Canvas  
    public void hideCanvas(){
        //gameObject.SetActive(false);
        textBullets.gameObject.SetActive(false);
        imageBullets.gameObject.SetActive(false);
        textCactus.gameObject.SetActive(false);
        imageCactus.gameObject.SetActive(false);

        //show label final
        label.gameObject.SetActive(true);
        time.gameObject.SetActive(true);
    }

    // Setters
    public void setBullets(string bullets){
        textBullets.text = bullets;
    }

    // Setters
    public void setCactues(string cactus){
        textCactus.text = cactus;
    }

    public void setTime(string time){
        this.time.text = time;
    }

}

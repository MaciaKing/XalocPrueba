using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public Text textBullets;  // Texto para la cantidad de balas
    public Text textShield;   // Texto para la cantidad de escudos

    // Método para actualizar el valor del texto de las balas
    public void setBullets(string bullets)
    {
        textBullets.text = bullets;
    }

    // Método para actualizar el valor del texto de los escudos
    public void setShield(string shield)
    {
        textShield.text = shield;
    }
}

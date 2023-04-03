using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public Button button1; 
    public Button button2; 
    public string nombreEscena; // Nombre de la escena a cargar
    public string nombreEscena2;
    public GameObject menuPrincipal; // Objeto del menú principal

    // Start is called before the first frame update
    void Start()
    {
        // Asociar la función "CargarEscena" al botón
        button1.onClick.AddListener(() => StartCoroutine(CargarEscenaAsync(nombreEscena)));
        button2.onClick.AddListener(() => StartCoroutine(CargarEscenaAsync(nombreEscena2)));
    }

    IEnumerator CargarEscenaAsync(string nombreEscena)
    {
        // Cargar la escena indicada por nombre
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(nombreEscena);

        // Esperar a que la escena se cargue completamente
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Esconder el menú principal
        menuPrincipal.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public Button button1; 
    public Button button2; 
    public string sceneName; // Name of the scene to load
    public string sceneName2;
    public GameObject mainMenu; // Main menu object

    // Start is called before the first frame update
    void Start()
    {
        // Associate the "LoadSceneAsync" function with the button
        button1.onClick.AddListener(() => StartCoroutine(LoadSceneAsync(sceneName)));
        button2.onClick.AddListener(() => StartCoroutine(LoadSceneAsync(sceneName2)));
    }

    IEnumerator LoadSceneAsync(string sceneName)
    {
        // Load the scene indicated by the name
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

        // Wait for the scene to load completely
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Hide the main menu
        mainMenu.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    

    private void Awake()
    {
        if (!instance) // si instance no tiene informacion 
        {
            instance = this; // instance se asigna a este objeto 
            DontDestroyOnLoad(gameObject); // se indica que este obj no se destruya con la carga de escenas 
        }
        else // si instance tiene info 
        {
            Destroy(gameObject); // se destruye el gameObject, para que no haya dos mas gamemanagers en el juego

        }
    }

    // callback---> funcion que se va a llamar en el onclick de los botones 
    public void LoadScene(string sceneName)
    {

        SceneManager.LoadScene(sceneName);
       
    }

    public void ExitGame()
    {
        Debug.Log("Exit!!");
        Application.Quit();
    }
}


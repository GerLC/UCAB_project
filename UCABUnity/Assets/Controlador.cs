﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controlador : MonoBehaviour
{
    public void CambiarEscena(string nombre)
    {
        print("Cambiando a la escena " + nombre);
        SceneManager.LoadScene(nombre);
 
        /*if()){
            Time.timeScale = 1f;
        }*/
    }

    public void Salid()
    {
        print("Saliendo del juego");
        Application.Quit();
    }
}

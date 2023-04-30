using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Comienzo : MonoBehaviour
{
    public GameObject panelControles;
    public GameObject panelPrincipal;
    public string nombreEscena;


    public void Jugar()
    {
        SceneManager.LoadScene(this.nombreEscena);
    }

    public void MostrarControles()
    {
        this.panelPrincipal.SetActive(false);
        this.panelControles.SetActive(true);
    }

    public void Cerrar()
    {
        this.panelControles.SetActive(false);
        this.panelPrincipal.SetActive(true);
    }

    //boton salir
    public void Apagar()
    {
        Application.Quit();
    }
}

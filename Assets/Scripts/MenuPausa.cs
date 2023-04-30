using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public static bool juegoPausado = false;
    public GameObject textoSonido;
    public GameObject menuPausa;
    public GameObject panelInstrucciones;
    public GameObject panelCreditos;
    public GameObject concentrador;
    public GameObject personaje;
    public string nombreEscena;


    private void Start()
    {
        this.menuPausa.SetActive(false);
        //cambiamos el texto de poner o quitar el sonido 
        if (FVG.sonidoActivado == true)
        {
            this.textoSonido.GetComponent<Text>().text = "QUITAR SONIDO";
        }
        else
        {
            this.textoSonido.GetComponent<Text>().text = "PONER SONIDO";
        }

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (juegoPausado)
            {
                Regresar();
            }
            else
            {
                Pausa();
            }
        }

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void Regresar()
    {
        this.menuPausa.SetActive(false);
        this.panelInstrucciones.SetActive(false);
        this.panelCreditos.SetActive(false);
        this.concentrador.SetActive(true);

        this.personaje.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = true;

        Time.timeScale = 1f;
        juegoPausado = false;
    }


    private void Pausa()
    {
        this.menuPausa.SetActive(true);
        this.concentrador.SetActive(false);

        
        this.personaje.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;

        Time.timeScale = 0f;
        juegoPausado = true;
    }

    public void MostrarInstrucciones()
    {
        this.menuPausa.SetActive(false);
        this.panelInstrucciones.SetActive(true);
        this.panelCreditos.SetActive(false);
    }


    public void MostrarCreditos()
    {
        this.menuPausa.SetActive(false);
        this.panelInstrucciones.SetActive(false);
        this.panelCreditos.SetActive(true);
    }


    public void ConmutarSonido()
    {
        if (FVG.sonidoActivado == true)
        {
            FVG.sonidoActivado = !FVG.sonidoActivado;
            this.textoSonido.GetComponent<Text>().text = "PONER SONIDO";
            AudioListener.volume = 0f;
        }
        else
        {
            FVG.sonidoActivado = !FVG.sonidoActivado;
            this.textoSonido.GetComponent<Text>().text = "QUITAR SONIDO";
            AudioListener.volume = 1f;
        }
    }

    //boton cerrar de cada uno de los paneles de instrucciones y creditos
    public void Cerrar()
    {
        this.menuPausa.SetActive(true);
        this.panelInstrucciones.SetActive(false);
        this.panelCreditos.SetActive(false);
    }


    //boton salir
    public void MenuPrincipal()
    {
        SceneManager.LoadScene(this.nombreEscena);
    }
}


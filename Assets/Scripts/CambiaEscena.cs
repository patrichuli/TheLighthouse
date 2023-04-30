using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiaEscena : MonoBehaviour
{
    public string nombreEscena;
    public GameObject contador;
    private bool cambia = false;

    private void Update()
    {
        if (this.contador.GetComponent<CapacidadContar>().llavesRecogidas == this.contador.GetComponent<CapacidadContar>().llavesTotales && this.contador.GetComponent<CapacidadContar>().SupervivenciaRecogida == this.contador.GetComponent<CapacidadContar>().SupervivenciaTotal)
        {
            cambia = true;
        }
    }


    private void OnTriggerEnter()
    {
        
        if (cambia)
        {
            SceneManager.LoadScene(this.nombreEscena);
        }

    }
}

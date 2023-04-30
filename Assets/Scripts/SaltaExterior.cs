using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaltaExterior : MonoBehaviour
{
    public string nombreEscena;
    public GameObject contador;
    private bool cambia = false;

    private void Update()
    {
        if (this.contador.GetComponent<CapacidadContar>().objetosRecogidos == this.contador.GetComponent<CapacidadContar>().objetosTotales)
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

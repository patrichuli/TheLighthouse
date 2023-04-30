using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapacidadContar : MonoBehaviour
{
     //no aparece en el inspector
    [HideInInspector] public int llavesRecogidas = 0;
    [HideInInspector] public int medicinaRecogida = 0;
    [HideInInspector] public int objetosRecogidos = 0;
    [HideInInspector] public int SupervivenciaRecogida = 0;

    [SerializeField] //aparece en el inspector
    public int llavesTotales = 1;
    public int medicinaTotal = 1;
    public int objetosTotales = 3;
    public int SupervivenciaTotal = 2;


    public GameObject puerta;
    public GameObject verja;
    public GameObject personaje;

    private void Update()
    {
        if(this.llavesRecogidas == this.llavesTotales && this.SupervivenciaRecogida == this.SupervivenciaTotal)
        {
            this.puerta.GetComponent<Animation>().Play("AbrirVerja");
            Object.Destroy(this);
        }

        if(this.objetosRecogidos == 1)
        {
            this.personaje.tag = "Puerta2";
        }
        else if(this.objetosRecogidos == 2)
        {
            this.personaje.tag = "Casa";
        }





    }
}

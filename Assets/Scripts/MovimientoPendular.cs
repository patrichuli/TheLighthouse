using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPendular : MonoBehaviour
{
    public float angulosArco;
    public float velocidad;

    private Quaternion qInicial;
    private Quaternion qFinal;

    private void Start()
    {
        if(this.velocidad == 0)
        {
            this.velocidad = 1;
        }

        this.qInicial = this.transform.rotation * Quaternion.Euler(this.angulosArco / 2f, 0f, 0f);
        this.qFinal = this.transform.rotation * Quaternion.Euler(-(this.angulosArco / 2f), 0f, 0f);
    }

    private void Update()
    {
        this.transform.rotation = Quaternion.Slerp(this.qInicial, this.qFinal, 
            (Mathf.Sin(Time.time * this.velocidad) + 1f) / 2f);
    }
}

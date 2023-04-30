using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : MonoBehaviour
{
    public float distancia;
    public float velocidad;

    private float equisInicial;
    private float equisFinal;

    private void Start()
    {
        this.equisInicial = this.transform.position.x;
        this.equisFinal = this.equisInicial + this.distancia;
    }

    private void Update()
    {
        Vector3 posicionTemp = this.transform.position;
        posicionTemp.x = Mathf.Lerp(this.equisInicial, this.equisFinal, Mathf.PingPong(Time.time * this.velocidad, 1f));
        this.transform.position = posicionTemp;
    }
}

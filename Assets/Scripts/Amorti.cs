using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amorti : MonoBehaviour
{
    //altura hasta la que sube la guillotina
    public float distanciaSubida;

    //clip de audio, bajada
    public AudioClip sonido;

    //variables para el movimiento, Modificamos solo la y
    private float alturaIni;
    private float alturaFin;

    //variables para la funcion SmoothDamp()
    private float velocidadActual = 0f;
    private float tiempoAmortiguado = 1f;

    //variable para conmutar entre el movimiento amortiguado de subida
    //y el de caida libre de bajada
    private bool ascendiendo = true;

    private void Start()
    {
        alturaIni = this.transform.position.y;
        alturaFin = this.transform.position.y + this.distanciaSubida;
    }

    private void Update()
    {
        if (this.ascendiendo == true)
        {
            //SmoothDamp se aproxima a la posicion final sin jamas llegar hasta ella


            if (Mathf.Abs(this.alturaFin - this.transform.position.y) > 0.01f)
            {
                float nuevaAltura = Mathf.SmoothDamp(this.transform.position.y, this.alturaFin, ref this.velocidadActual, this.tiempoAmortiguado);
                Vector3 posicionTemp = this.transform.position;
                posicionTemp.y = nuevaAltura;
                this.transform.position = posicionTemp;
            }
            else
            {
                this.ascendiendo = false;
                this.ReproducirSonidoLocalizado(this.sonido, this.transform.position + new Vector3(0f, -5f, 0f), 1f);
            }


        }
        else
        {
            if (this.transform.position.y > this.alturaIni)
            {
                Vector3 posicionTemp = this.transform.position;
                posicionTemp.y -= 7f * Time.deltaTime;
                this.transform.position = posicionTemp;
            }
            else
            {
                this.ascendiendo = true;
            }

        }
    }


    AudioSource ReproducirSonidoLocalizado(AudioClip sonido, Vector3 posicion, float volumen)
    {
        //gameobject temporal
        GameObject objetoTemporal = new GameObject("AudioTemporal");
        //posicion
        objetoTemporal.transform.position = posicion;
        //añadimos un audiosource
        AudioSource aSource = objetoTemporal.AddComponent<AudioSource>();
        //se le asigna el sonido
        aSource.clip = sonido;
        //propiedades de audiosource
        aSource.volume = volumen;
        aSource.spatialBlend = 1f;
        //se activa reproduccion
        aSource.Play();
        //se destruye el objeto al finalizar el tiempo de reproduccion
        Destroy(objetoTemporal, sonido.length);
        //se decuelve la referencia al audiosource
        return aSource;
    }
}

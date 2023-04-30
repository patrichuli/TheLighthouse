using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetosEncontrados : MonoBehaviour
{
    public GameObject contador;
    public GameObject puerta1;
    public GameObject azotea;
    public GameObject salida1;
    public GameObject salida2;
    public AudioClip sonido_llave1;
    public AudioClip sonido_llave2;
    public AudioClip sonido_llave3;
    public float volumen = 1f;


    private void OnTriggerEnter(Collider other)
    {
        this.contador.GetComponent<CapacidadContar>().objetosRecogidos++;
        Object.Destroy(this.gameObject);
        if(other.tag == "Puerta1")
        {
            this.puerta1.transform.Rotate(0f, 90f, 0f);
            AudioSource.PlayClipAtPoint(this.sonido_llave1, other.transform.position, this.volumen);
        }
        else if(other.tag == "Puerta2")
        {
            this.azotea.transform.Rotate(0f, 90f, 0f);
            AudioSource.PlayClipAtPoint(this.sonido_llave2, other.transform.position, this.volumen);
        }
        else if (other.tag == "Casa")
        {
            this.salida1.transform.Rotate(0f, 90f, 0f);
            this.salida2.transform.Rotate(0f, -90f, 0f);
            AudioSource.PlayClipAtPoint(this.sonido_llave3, other.transform.position, this.volumen);
        }


    }
}

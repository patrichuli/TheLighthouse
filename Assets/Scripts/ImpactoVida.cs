using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImpactoVida : MonoBehaviour
{
    public AudioClip sonido;
    public float volumen = 1f;
    public GameObject imagenImpacto;
    public float duracion = 0.5f;
    public GameObject concentrador;

    private bool control = true;
    private bool recuperado = true;

    private void Awake()
    {
        if(this.sonido == null)
        {
            Debug.LogError("Se ha de adjuntar un sonido.");
        }

        this.imagenImpacto.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0f);
    }

    private void OnTriggerStay(Collider intruso)
    {
        if(intruso.tag == "Nocivo" && this.recuperado == true)
        {
            this.StartCoroutine(this.RecibirHerida(this.duracion));
        }        
    }

    //corrutina
    private IEnumerator RecibirHerida(float duracion)
    {
        this.recuperado = false;
        duracion = duracion / 2f;

        //actualizamos el estado del concentrador de datos modificando la variable vidas,
        //en él contenida, cada vez que recibimos un impacto
        this.concentrador.GetComponent<InterfazVida>().vidas -= 1;

        AudioSource.PlayClipAtPoint(this.sonido, this.transform.position, this.volumen);

        //de invisible a opaco
        for(float i = 0f; i <= 1f; i += Time.deltaTime / duracion)
        {
            this.imagenImpacto.GetComponent<Image>().color = new Color(1f, 1f, 1f, Mathf.Lerp(0f, 1f, i));
            yield return null;

        }

        //de opaco a invisible
        for (float i = 0f; i <= 1f; i += Time.deltaTime / duracion)
        {
            this.imagenImpacto.GetComponent<Image>().color = new Color(1f, 1f, 1f, Mathf.Lerp(1f, 0f, i));
            yield return null;

        }

        this.recuperado = true;

    }
}

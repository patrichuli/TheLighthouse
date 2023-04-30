using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LlaveEcontrada : MonoBehaviour
{

    public GameObject contador;
    public AudioClip sonido;
    public float volumen = 1f;

    private void OnTriggerEnter(Collider other)
    {
        this.contador.GetComponent<CapacidadContar>().llavesRecogidas++;
        Object.Destroy(this.gameObject);
        AudioSource.PlayClipAtPoint(this.sonido, other.transform.position, this.volumen);
    }


}

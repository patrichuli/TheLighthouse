using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Supervivencia : MonoBehaviour
{

    public GameObject contador;

    private void OnTriggerEnter()
    {
        this.contador.GetComponent<CapacidadContar>().SupervivenciaRecogida++;
        Object.Destroy(this.gameObject);
    }
}

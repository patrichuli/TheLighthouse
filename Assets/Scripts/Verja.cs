using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verja : MonoBehaviour
{
    public GameObject contador;
    public GameObject verja;
    private bool abre = false;

    private void Update()
    {
        if(this.contador.GetComponent<CapacidadContar>().objetosRecogidos == 3)
        {
            this.verja.transform.Rotate(0f, -90f, 0f);
        }
    }

    
} 

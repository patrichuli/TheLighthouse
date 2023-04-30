using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapacidadRotar : MonoBehaviour
{
    public float angulosPorFrame = 0;

    private void Update()
    {
        this.GetComponent<Transform>().Rotate(0f, this.angulosPorFrame, 0f);
    }

    
}

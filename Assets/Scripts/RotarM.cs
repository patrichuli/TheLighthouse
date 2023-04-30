using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarM : MonoBehaviour
{
    public float angulosPorFrame = 0;

    private void Update()
    {
        this.GetComponent<Transform>().Rotate(this.angulosPorFrame, 0f, 0f);
    }

    
}

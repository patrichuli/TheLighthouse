using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarY : MonoBehaviour
{
    public float velocidad = 130f;
    public string sentido;
 

    private void Update()
    {
        if(this.sentido == "horario" || this.sentido == "positivo")
        {
            this.transform.Rotate(new Vector3(0f, 1f, 0f) * this.velocidad * Time.deltaTime);
        }
        else
        {
            this.transform.Rotate(0f, -1f * this.velocidad * Time.deltaTime, 0f);
        }

    }

    

}

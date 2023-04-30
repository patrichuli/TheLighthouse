using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfazVida : MonoBehaviour
{

    public Texture corazonLleno;
    public Texture corazonVacio;
    public GUIStyle textoGameOver;

    //esta variable la actualizara el script impactovida
    [HideInInspector]
    public int vidas = 3;

    //recarga la escena en caso de perder todas las vidas
    public bool reiniciarNivel = false;


    private void Update()
    {
        //perdemos todas las vidas y activamos una corrutina, que tras x segundos cambiara
        //el valor de reiniciarNivel a true
        if(this.vidas <= 0)
        {
            StartCoroutine(MostrarMensaje(5f));
        }

        //recargamos la escena si se han perdido todas las vidas
        if(this.reiniciarNivel == true)
        {
            SceneManager.LoadScene("Exterior");
        }
    }


    private IEnumerator MostrarMensaje(float tiempo)
    {
        float i = 0f;

        while(i < tiempo)
        {
            i += Time.deltaTime;
            yield return null;
        }

        reiniciarNivel = true;
    }


    private void OnGUI()
    {
        //gentionan los corazones de las vidas
        if(this.vidas == 3)
        {
            GUI.Label(new Rect(10f, 10f, 50f, 50f), this.corazonLleno);
            GUI.Label(new Rect(60f, 10f, 50f, 50f), this.corazonLleno);
            GUI.Label(new Rect(110f, 10f, 50f, 50f), this.corazonLleno);
        }

        if (this.vidas == 2)
        {
            GUI.Label(new Rect(10f, 10f, 50f, 50f), this.corazonLleno);
            GUI.Label(new Rect(60f, 10f, 50f, 50f), this.corazonLleno);
            GUI.Label(new Rect(110f, 10f, 50f, 50f), this.corazonVacio);
        }

        if (this.vidas == 1)
        {
            GUI.Label(new Rect(10f, 10f, 50f, 50f), this.corazonLleno);
            GUI.Label(new Rect(60f, 10f, 50f, 50f), this.corazonVacio);
            GUI.Label(new Rect(110f, 10f, 50f, 50f), this.corazonVacio);
        }

        //game over
        if (this.vidas <= 0)
        {
            GUI.Label(new Rect(10f, 10f, 50f, 50f), this.corazonVacio);
            GUI.Label(new Rect(60f, 10f, 50f, 50f), this.corazonVacio);
            GUI.Label(new Rect(110f, 10f, 50f, 50f), this.corazonVacio);
            GUI.Label(new Rect(Screen.width / 2f - 50f, Screen.height / 2f - 15f, 100f, 30f), "GAME OVER", this.textoGameOver);
        }
    }

}

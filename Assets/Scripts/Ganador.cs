using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ganador : MonoBehaviour
{
    public GUIStyle textoGanador;
    private void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2f - 50f, Screen.height / 2f - 15f, 100f, 30f), "SALVASTE A LA HUMANIDAD\nDE LA ENFERMEDAD", this.textoGanador);
    }
}

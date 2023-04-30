using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eventos : MonoBehaviour
{
    public GameObject lienzoMenuPausa;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && this.lienzoMenuPausa.GetComponent<Canvas>().enabled == false)
        {
            //desactivamos el componente canvas en lugar de todo el gameobject lienzo
            this.lienzoMenuPausa.GetComponent<Canvas>().enabled = true;

            //desactivamos y reactivamos el gameobject lienzo por las animaciones
            this.lienzoMenuPausa.SetActive(false);
            this.lienzoMenuPausa.SetActive(true);

            //al abrir el menu de pausa detemos el movimiento del juego
            Time.timeScale = 0f;

            //desactivamos tambien el script que controla la vision del avatar para evitar
            //que al regresar éste aparezca mirando hacia otro sitio diferente
            if(GameObject.FindWithTag("Player") != null)
                GameObject.FindWithTag("Player").GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

        }
    }
}

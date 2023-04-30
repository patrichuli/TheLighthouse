using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaltoCasa : MonoBehaviour
{
    public string nombreEscena;
    public GameObject vidas;

    private void OnTriggerEnter()
    {
        if (this.vidas.GetComponent<InterfazVida>().vidas > 0)
        {
            SceneManager.LoadScene(this.nombreEscena);
        }
        
    }
}

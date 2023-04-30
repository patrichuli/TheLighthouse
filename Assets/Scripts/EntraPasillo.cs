using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntraPasillo : MonoBehaviour
{
    public string nombreEscena;


    private void OnTriggerEnter()
    {
        SceneManager.LoadScene(this.nombreEscena);
        

    }
}

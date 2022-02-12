using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Salir : MonoBehaviour {

    public GameObject transito;
    public Animator audioSource;

    public void Salida()
    {
        StartCoroutine("Transicion");
    }

    IEnumerator Transicion()
    {
        transito.SetActive(true);
        audioSource.SetBool("volumen", true);
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(4);
    }
}

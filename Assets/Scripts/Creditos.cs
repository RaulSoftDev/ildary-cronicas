using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Creditos : MonoBehaviour {

    public GameObject transicionNegro;
    public Animator audioSource;

    public void Menu()
    {
        StartCoroutine("Cambio");
    }

    IEnumerator Cambio()
    {
        audioSource.SetBool("volumen", true);
        transicionNegro.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(4);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Titulo : MonoBehaviour {

    [SerializeField] Animator animator;
    [SerializeField] Animator animator2;
    [SerializeField] GameObject boton;
    [SerializeField] Animator tap;
    public Animator aNegro;
    public GameObject fadeIn;
    public Animator audioSource;
    public GameObject partida;
    public GameObject texto;
    public GameObject menuCargar;
    public GameObject menuNormal;
    public GameObject tituloTexto;

    public void OnTitle()
    {
        StartCoroutine("Buttons");
    }

    IEnumerator Buttons()
    {
        animator.SetBool("Tap", true);
        tap.SetBool("Fade", true);
        yield return new WaitForSeconds(1.10f);
        boton.SetActive(false);
        yield return new WaitForSeconds(1.0f);
        animator2.SetBool("Menu", true);
    }

    public void SceneLoad()
    {
        StartCoroutine("Scene");
    }

    IEnumerator Scene()
    {
        fadeIn.SetActive(true);
        audioSource.SetBool("volumen", true);
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(1);
    }

    public void Creditos()
    {
        StartCoroutine("Scene2");
    }

    IEnumerator Scene2()
    {
        audioSource.SetBool("volumen", true);
        fadeIn.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(4);
    }

    public void CreditosEntrar()
    {
        StartCoroutine("Scene3");
    }

    IEnumerator Scene3()
    {
        fadeIn.SetActive(true);
        audioSource.SetBool("volumen", true);
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(2);
    }

    public void Opciones()
    {
        StartCoroutine("OpcionesEntrar");
    }

    IEnumerator OpcionesEntrar()
    {
        fadeIn.SetActive(true);
        audioSource.SetBool("volumen", true);
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(3);
    }

    public void Load()
    {
        tituloTexto.SetActive(false);
        menuNormal.SetActive(false);
        menuCargar.SetActive(true);
    }

    public void NotLoad()
    {
        menuCargar.SetActive(false);
        menuNormal.SetActive(true);
        tituloTexto.SetActive(true);
    }

}

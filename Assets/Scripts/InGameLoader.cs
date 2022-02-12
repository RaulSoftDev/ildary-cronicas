using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameLoader : MonoBehaviour {

    public GameObject escenaNegro;
    public Animator audioSource;
    public Animator audioSource2;
    public GameObject menu;
    public GameObject opciones;
    public GameObject transicion;
    public GameObject transicion2;
    public AudioSource principal;
    public AudioSource opcionesA;
    public GameObject dentro;
    public GameObject noTocar;
    public GameObject menuSalir;
    public GameObject canvas;
    public GameObject transicionFuera;
    public GameObject menuCargarOn;
    public GameObject menuOff;

    public void MenuPrincipal()
    {
        StartCoroutine("CargarMenu");
    }

    IEnumerator CargarMenu()
    {
        Time.timeScale = 1;
        escenaNegro.SetActive(true);
        audioSource.SetBool("volumen", true);
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(4);
    }

    public void Opciones()
    {
        StartCoroutine("OpcionesEntrar");
    }

    IEnumerator OpcionesEntrar()
    {
        Time.timeScale = 1;
        escenaNegro.SetActive(true);
        audioSource.SetBool("volumen", true);
        yield return new WaitForSeconds(2.0f);
        opciones.SetActive(true);
        escenaNegro.SetActive(false);
    }

    public void CerrarMenu()
    {
        menu.SetActive(false);
        Time.timeScale = 1;
        StartCoroutine("NoTocar");
    }

    public void AbrirMenu()
    {
  
        menu.SetActive(true);
        Time.timeScale = 0;
    }

    public void AbrirMenu2()
    {
        StartCoroutine("Menu");
    }

    IEnumerator Menu()
    {
        Time.timeScale = 1;
        transicion.SetActive(true);
        audioSource2.SetBool("volumen", true);
        yield return new WaitForSeconds(2.0f);
        transicion2.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        opciones.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        dentro.SetActive(true);
        transicion.SetActive(false);
        audioSource.SetBool("volumen", false);
        audioSource.Play("Intermedio", 0);
        principal.volume = 1.0f;
        opcionesA.volume = 1.0f;
        yield return new WaitForSeconds(2.0f);
        Time.timeScale = 0;
    }

    IEnumerator NoTocar()
    {
        noTocar.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        noTocar.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }

    private void Update()
    {
        if (menuSalir.activeInHierarchy)
        {
            menuSalir.transform.parent = canvas.transform;
        }
    }

    public void CargarPartida()
    {
        Time.timeScale = 1;
        menuOff.SetActive(false);
        menuCargarOn.SetActive(true);
    }


}

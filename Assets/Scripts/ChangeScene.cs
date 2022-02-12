using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour {

    public GameObject parrafo1;
    public GameObject parrafo2;
    public GameObject titulo;

    public GameObject escuchas;
    public GameObject preguntas;

    public GameObject intermedio;
    public GameObject diasDespues;

    #region Parrafo 2
    public void Parrafo2()
    {
        StartCoroutine("SegundoParrafo");
    }

    IEnumerator SegundoParrafo()
    {
        parrafo1.SetActive(false);
        yield return new WaitForSeconds(0.15f);
        parrafo2.SetActive(true);
    }
    #endregion

    #region Parrafo 1
    public void Parrafo1()
    {
        StartCoroutine("PrimerParrafo");
    }

   IEnumerator PrimerParrafo()
    {
        titulo.SetActive(false);
        yield return new WaitForSeconds(0.30f);
        parrafo1.SetActive(true);
    }
    #endregion

    #region Escuchas
    IEnumerator OpcionEscuchar()
    {
        parrafo2.SetActive(false);
        yield return new WaitForSeconds(0.15f);
        escuchas.SetActive(true);
    }

    public void VasAEscuchar()
    {
        StartCoroutine("OpcionEscuchar");
    }
    #endregion

    #region Preguntas
    IEnumerator OpcionPreguntar()
    {
        parrafo2.SetActive(false);
        yield return new WaitForSeconds(0.15f);
        preguntas.SetActive(true);
    }
    
    public void VasAPreguntar()
    {
        StartCoroutine("OpcionPreguntar");
    }
    #endregion

    #region Intermedio
    IEnumerator IntermissionEscuchas()
    {
        escuchas.SetActive(false);
        yield return new WaitForSeconds(0.15f);
        intermedio.SetActive(true);
    }

    IEnumerator IntermissionPreguntas()
    {
        preguntas.SetActive(false);
        yield return new WaitForSeconds(0.15f);
        intermedio.SetActive(true);
    }

    public void OnIntermission()
    {
        if(escuchas.activeInHierarchy == true)
        {
            StartCoroutine("IntermissionEscuchas");
        }
        if(preguntas.activeInHierarchy == true)
        {
            StartCoroutine("IntermissionPreguntas");
        }
    }
    #endregion

    IEnumerator DiasDespues()
    {
        intermedio.SetActive(false);
        yield return new WaitForSeconds(0.15f);
        diasDespues.SetActive(true);
    }

    public void OnDiasDespues()
    {
        StartCoroutine("DiasDespues");
    }
}

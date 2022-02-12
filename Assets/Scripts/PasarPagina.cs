using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasarPagina : MonoBehaviour {

    public GameObject apagar;
    public GameObject encender;

    IEnumerator Cambiar()
    {
        transform.parent = null;
        apagar.SetActive(false);
        yield return new WaitForSeconds(0.15f);
        encender.SetActive(true);
        transform.parent = apagar.transform;
    }

    public void CambiarPagina()
    {
        StartCoroutine("Cambiar");
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasarPagina2 : MonoBehaviour {

    public GameObject apagar;
    public GameObject encender;

    IEnumerator Pasar()
    {
        //transform.parent = null;
        apagar.SetActive(false);
        yield return new WaitForSeconds(0.15f);
        encender.SetActive(true);
        gameObject.SetActive(false);
    }

    public void PasarPagina()
    {
        StartCoroutine("Pasar");
    }
}

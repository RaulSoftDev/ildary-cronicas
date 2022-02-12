using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTap : MonoBehaviour {

    public GameObject parrafo1;
    public GameObject titulo;


	void Start () {
		
	}
	

	void Update () {

        if (Input.GetKeyDown(KeyCode.E));
        {
            StartCoroutine("Toque");
        }
	}

    IEnumerator Toque()
    {
        titulo.SetActive(false);
        yield return new WaitForSeconds(0.15f);
        parrafo1.SetActive(true);
    }
}

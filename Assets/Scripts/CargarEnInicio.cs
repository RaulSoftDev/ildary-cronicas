using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargarEnInicio : MonoBehaviour {

    GameObject[] lectura;
    public Transform partes;
    public string[] carga = new string[8];
    string partida;

    // Use this for initialization
    void Start () {
        lectura = FindObjectsOfType<GameObject>();

        foreach (GameObject i in lectura)
        {
            if (i.transform.parent == partes && i.transform.name != "Fondo" && i.transform.tag != "transicion")
            {
                i.SetActive(false);
            }
        }

        partida = PlayerPrefs.GetString("Cargar");
        carga = PlayerPrefsX.GetStringArray(partida);

        foreach (string pagina in carga)
        {
            MyUtils.FindIncludingInactive(pagina).SetActive(true);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

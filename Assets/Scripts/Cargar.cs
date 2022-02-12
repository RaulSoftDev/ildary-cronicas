using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Cargar : MonoBehaviour {

    public GameObject texto1;
    public GameObject texto2;
    public GameObject texto3;
    public GameObject texto4;

    public GameObject menuCargar;
    public GameObject menuOn;

    public GameObject animacionDentro;
    public Animator audioDentro;

	// Use this for initialization
	void Start () {
        //PlayerPrefs.DeleteAll();
	}
	
	// Update is called once per frame
	void Update () {

        if (PlayerPrefs.HasKey("Guardado1"))
        {
            texto1.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetString("Hora1");
        }
        else
        {
            texto1.GetComponent<TextMeshProUGUI>().text = "No hay datos guardados";
        }

        if (PlayerPrefs.HasKey("Guardado2"))
        {
            texto2.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetString("Hora2");
        }
        else
        {
            texto2.GetComponent<TextMeshProUGUI>().text = "No hay datos guardados";
        }

        if (PlayerPrefs.HasKey("Guardado3"))
        {
            texto3.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetString("Hora3");
        }
        else
        {
            texto3.GetComponent<TextMeshProUGUI>().text = "No hay datos guardados";
        }

        if (PlayerPrefs.HasKey("Guardado4"))
        {
            texto4.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetString("Hora4");
        }
        else
        {
            texto4.GetComponent<TextMeshProUGUI>().text = "No hay datos guardados";
        }

    }

    public void Cargar1()
    {
        if (PlayerPrefs.HasKey("Guardado1"))
        {
            StartCoroutine("Carga1");
        }
        
    }

    public void Cargar2()
    {
        if (PlayerPrefs.HasKey("Guardado2"))
        {
            StartCoroutine("Carga2");
        }
        
    }

    public void Cargar3()
    {
        if (PlayerPrefs.HasKey("Guardado3"))
        {
            StartCoroutine("Carga3");
        }
       
    }

    public void Cargar4()
    {
        if (PlayerPrefs.HasKey("Guardado4"))
        {
            StartCoroutine("Carga4");
        }
        
    }

    public void CerrarCargar()
    {
        menuCargar.SetActive(false);
        menuOn.SetActive(true);
    }

    IEnumerator Carga1()
    {
        animacionDentro.SetActive(true);
        audioDentro.SetBool("volumen", true);
        PlayerPrefs.SetString("Cargar", "Guardado1");
        yield return new WaitForSeconds(2.0f);  
        SceneManager.LoadScene(5);
    }

    IEnumerator Carga2()
    {
        animacionDentro.SetActive(true);
        audioDentro.SetBool("volumen", true);
        PlayerPrefs.SetString("Cargar", "Guardado2");
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(5);
    }

    IEnumerator Carga3()
    {
        animacionDentro.SetActive(true);
        audioDentro.SetBool("volumen", true);
        PlayerPrefs.SetString("Cargar", "Guardado3");
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(5);
    }

    IEnumerator Carga4()
    {
        animacionDentro.SetActive(true);
        audioDentro.SetBool("volumen", true);
        PlayerPrefs.SetString("Cargar", "Guardado4");
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(5);
    }

}

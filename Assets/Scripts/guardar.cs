using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class guardar : MonoBehaviour {

    //private const int count = 10;

    GameObject[] canvas;
    public Transform padre;
    bool hecho = false;
    public string[] array = new string[12];
    public string[] array2 = new string[12];
    public string[] array3 = new string[12];
    public string[] array4 = new string[12];

    int posicion = 0;

    public GameObject menuSave;
    public GameObject bloqueo;
    public GameObject guardadoExito;
    public GameObject menuIn;

    //Textos de los puntos de guardado
    public GameObject texto1;
    public GameObject texto2;
    public GameObject texto3;
    public GameObject texto4;

    //Si ya hay un guardado
    public GameObject sihay2;
    public GameObject sihay3;
    public GameObject sihay4;

	// Use this for initialization
	void Start () {
        //SiActivo();
        //PlayerPrefs.DeleteAll();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (PlayerPrefs.HasKey("Hora1"))
        {
            texto1.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetString("Hora1");
        }
        else
        {
            texto1.GetComponent<TextMeshProUGUI>().text = "Espacio vacío";
        }

        if (PlayerPrefs.HasKey("Hora2"))
        {
            texto2.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetString("Hora2");
        }
        else
        {
            texto2.GetComponent<TextMeshProUGUI>().text = "Espacio vacío";
        }

        if (PlayerPrefs.HasKey("Hora3"))
        {
            texto3.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetString("Hora3");
        }
        else
        {
            texto3.GetComponent<TextMeshProUGUI>().text = "Espacio vacío";
        }

        if (PlayerPrefs.HasKey("Hora4"))
        {
            texto4.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetString("Hora4");
        }
        else
        {
            texto4.GetComponent<TextMeshProUGUI>().text = "Espacio vacío";
        }
    }

    public void SiGuardar1()
    {
        if (PlayerPrefs.HasKey("Guardado1"))
        {

            guardadoExito.SetActive(true);
            
        }
        else
        {
            canvas = FindObjectsOfType<GameObject>();
            posicion = 0;

            foreach (GameObject i in canvas)
            {
                if (i.transform.parent == padre)
                {
                    array.SetValue(i.name, posicion);
                    posicion += 1;
                }
            }
            PlayerPrefsX.SetStringArray("Guardado1", array);
            PlayerPrefs.SetString("Hora1", texto1.GetComponent<TextMeshProUGUI>().text = System.DateTime.Now.ToString("HH:mm - dd/MM"));
        }
        
    }

    public void SiGuardar2()
    {
        if (PlayerPrefs.HasKey("Guardado2"))
        {

            sihay2.SetActive(true);

        }
        else
        {
            canvas = FindObjectsOfType<GameObject>();
            posicion = 0;

            foreach (GameObject i in canvas)
            {
                if (i.transform.parent == padre)
                {
                    array2.SetValue(i.name, posicion);
                    posicion += 1;
                }
            }
            PlayerPrefsX.SetStringArray("Guardado2", array2);
            PlayerPrefs.SetString("Hora2", texto2.GetComponent<TextMeshProUGUI>().text = System.DateTime.Now.ToString("HH:mm - dd/MM"));
        }
    }

    public void SiGuardar3()
    {
        if (PlayerPrefs.HasKey("Guardado3"))
        {

            sihay3.SetActive(true);

        }
        else
        {
            canvas = FindObjectsOfType<GameObject>();
            posicion = 0;

            foreach (GameObject i in canvas)
            {
                if (i.transform.parent == padre)
                {
                    array3.SetValue(i.name, posicion);
                    posicion += 1;
                }
            }
            PlayerPrefsX.SetStringArray("Guardado3", array3);
            PlayerPrefs.SetString("Hora3", texto3.GetComponent<TextMeshProUGUI>().text = System.DateTime.Now.ToString("HH:mm - dd/MM"));
        }
    }

    public void SiGuardar4()
    {
        if (PlayerPrefs.HasKey("Guardado4"))
        {

            sihay4.SetActive(true);

        }
        else
        {
            canvas = FindObjectsOfType<GameObject>();
            posicion = 0;

            foreach (GameObject i in canvas)
            {
                if (i.transform.parent == padre)
                {
                    array4.SetValue(i.name, posicion);
                    posicion += 1;
                }
            }
            PlayerPrefsX.SetStringArray("Guardado4", array4);
            PlayerPrefs.SetString("Hora4", texto4.GetComponent<TextMeshProUGUI>().text = System.DateTime.Now.ToString("HH:mm - dd/MM"));
        }
        
    }

    public void MenuGuardar()
    {
        menuSave.SetActive(true);
        bloqueo.SetActive(true);
    }

    public void Cerrar()
    {
        menuSave.SetActive(false);
        StartCoroutine("BloqueoSeguridad");
    }

    public void CerrarGuardar()
    {
        guardadoExito.SetActive(false);
    }

    public void CerrarGuardar2()
    {
        sihay2.SetActive(false);
    }

    public void CerrarGuardar3()
    {
        sihay3.SetActive(false);
    }

    public void CerrarGuardar4()
    {
        sihay4.SetActive(false);
    }

    IEnumerator BloqueoSeguridad()
    {
        yield return new WaitForSeconds(1.0f);
        bloqueo.SetActive(false);
    }

    public void SiExiste1()
    {
        canvas = FindObjectsOfType<GameObject>();
        posicion = 0;

        foreach (GameObject i in canvas)
        {
            if (i.transform.parent == padre)
            {
                array.SetValue(i.name, posicion);
                posicion += 1;
            }
        }
        PlayerPrefsX.SetStringArray("Guardado1", array);
        PlayerPrefs.SetString("Hora1", texto1.GetComponent<TextMeshProUGUI>().text = System.DateTime.Now.ToString("HH:mm - dd/MM"));

        guardadoExito.SetActive(false);
    }

    public void SiExiste2()
    {
        canvas = FindObjectsOfType<GameObject>();
        posicion = 0;

        foreach (GameObject i in canvas)
        {
            if (i.transform.parent == padre)
            {
                array.SetValue(i.name, posicion);
                posicion += 1;
            }
        }
        PlayerPrefsX.SetStringArray("Guardado2", array);
        PlayerPrefs.SetString("Hora2", texto2.GetComponent<TextMeshProUGUI>().text = System.DateTime.Now.ToString("HH:mm - dd/MM"));

        sihay2.SetActive(false);
    }

    public void SiExiste3()
    {
        canvas = FindObjectsOfType<GameObject>();
        posicion = 0;

        foreach (GameObject i in canvas)
        {
            if (i.transform.parent == padre)
            {
                array.SetValue(i.name, posicion);
                posicion += 1;
            }
        }
        PlayerPrefsX.SetStringArray("Guardado3", array);
        PlayerPrefs.SetString("Hora3", texto3.GetComponent<TextMeshProUGUI>().text = System.DateTime.Now.ToString("HH:mm - dd/MM"));

        sihay3.SetActive(false);
    }

    public void SiExiste4()
    {
        canvas = FindObjectsOfType<GameObject>();
        posicion = 0;

        foreach (GameObject i in canvas)
        {
            if (i.transform.parent == padre)
            {
                array.SetValue(i.name, posicion);
                posicion += 1;
            }
        }
        PlayerPrefsX.SetStringArray("Guardado4", array);
        PlayerPrefs.SetString("Hora4", texto4.GetComponent<TextMeshProUGUI>().text = System.DateTime.Now.ToString("HH:mm - dd/MM"));

        sihay4.SetActive(false);
    }

}

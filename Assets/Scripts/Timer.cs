using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	[SerializeField] private Text uiText;
    [SerializeField] private float mainTimer;
    [SerializeField] private GameObject end;
    [SerializeField] private GameObject self;
    public GameObject efecto;

    private float timer;
    private bool canCount = true;
    private bool doOnce = false;

	void Start ()
    {
        timer = mainTimer;
        canCount = true;
	}
	
	void Update ()
    {
	    if(timer >= 0.0f && canCount)
        {
            timer -= Time.deltaTime;
            uiText.text = timer.ToString("F");
        }
        else if(timer <= 0.0f && !doOnce)
        {
            canCount = false;
            doOnce = true;
            uiText.text = "0.00";
            timer = 0.0f;
        }

        if(doOnce)
        {
            Debug.Log("FIN");
            StartCoroutine("Negro");
        }
	}

    IEnumerator Final()
    {
        transform.parent = null;
        canCount = false;
        self.SetActive(false);
        yield return new WaitForSeconds(0.01f);
        end.SetActive(true);
        transform.parent = self.transform;
    }

    IEnumerator Negro()
    {
        efecto.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        StartCoroutine("Final");
    }
}

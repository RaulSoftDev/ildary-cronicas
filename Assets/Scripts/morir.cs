using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class morir : MonoBehaviour {

    public GameObject transito;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Apagar()
    {
        yield return new WaitForSeconds(2.0f);
        transito.SetActive(false);
    }
}

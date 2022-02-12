using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Negro : MonoBehaviour {

    public GameObject negro;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        StartCoroutine("NegroFade");
		
	}

    IEnumerator NegroFade()
    {
        yield return new WaitForSeconds(2.10f);
        gameObject.SetActive(false);
    }
}

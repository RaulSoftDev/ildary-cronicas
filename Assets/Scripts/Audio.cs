using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {

    AudioSource audioSource;
    public AudioClip clip;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        DontDestroyOnLoad(gameObject);

        if (!audioSource.isPlaying)
        {
            Debug.Log(audioSource.isPlaying);
            audioSource.PlayOneShot(clip);
        }
 
    }

    // Use this for initialization
    void Start () {

       
        
    }
	
	// Update is called once per frame
	void Update () {

       

        
    }
}

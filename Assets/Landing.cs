using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Landing : MonoBehaviour {
    public Material[] material;
    Renderer rendere;


	// Use this for initialization
	void Start () {
        rendere = GetComponent<Renderer>();
        rendere.enabled = true;
        rendere.sharedMaterial = material[0];
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        rendere.sharedMaterial = material[1];
       
    }
}

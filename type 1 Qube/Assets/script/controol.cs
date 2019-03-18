using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controol : MonoBehaviour {

    public static string num;

	// Use this for initialization
	void Start () {

      
        //GetComponent<TextMesh>().text = num;
	}
	
	// Update is called once per frame
	void Update () {

        GetComponent<TextMesh>().text = num;

	}
}

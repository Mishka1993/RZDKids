using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyHelp : MonoBehaviour {
	public GameObject Destroyhelp;
	public GameObject Destroyhelp1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown(){

		Destroy(Destroyhelp);
		Destroy(Destroyhelp1);
	}
}

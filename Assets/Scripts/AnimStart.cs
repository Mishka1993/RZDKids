using System.Collections;
using UnityEngine;

public class AnimStart : MonoBehaviour {
	public Animator Train;
	public GameObject Array;
	void Start () {
		Train.enabled = false;
	}
	void OnMouseDown () {
		Train.enabled = true;
		Train.Rebind ();
		Train.SetTrigger ("Play");
		Array.SetActive (false);
	}

}
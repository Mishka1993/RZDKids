using System.Collections;
using UnityEngine;

public class AnimStop : MonoBehaviour {
public Animator Train;
public GameObject Array;
void Update(){
		Train.enabled=false;
    	Train.Rebind();
    	Train.SetTrigger("Play");
    	Array.SetActive(true);
	}
}

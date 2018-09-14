using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour {
public AudioSource Source;
	public void volume(){
		Source.volume = 1;
	}
	public void FadeOut(){
		StartCoroutine(FadeOutCoroutine());

	}
	private IEnumerator FadeOutCoroutine(){
		while(Source.volume!=0){
			Source.volume -= Time.deltaTime;
			yield return null;
		}
	//Source.Stop();
	}
}

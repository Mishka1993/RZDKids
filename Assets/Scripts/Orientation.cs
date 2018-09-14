using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orientation : MonoBehaviour {
private DeviceOrientation orientation;
public GameObject Portrait_Menu;
public GameObject Landscape_Menu;
	void Update() {
		orientation = Input.deviceOrientation;
	if (orientation == DeviceOrientation.LandscapeLeft || 
     	orientation == DeviceOrientation.LandscapeRight){
        	Portrait_Menu.SetActive(false);
        	Landscape_Menu.SetActive(true);
		}
		else if (orientation == DeviceOrientation.Portrait){
			Portrait_Menu.SetActive(true);
    		Landscape_Menu.SetActive(false);
		}
	}
}
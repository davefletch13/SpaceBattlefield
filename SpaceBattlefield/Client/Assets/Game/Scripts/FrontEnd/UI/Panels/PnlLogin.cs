using UnityEngine;
using System.Collections;

public class PnlLogin : UIPanelController {

	void Awake () {
		
		hidePosition = new Vector3(0,-700,0);
		showPosition = new Vector3(0,-300,0);
		currentlyHidden = false;
		
	}
}
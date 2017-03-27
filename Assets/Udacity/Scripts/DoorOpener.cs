using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour {

	private Animator anim;
	
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.instance.Opening == true) {
			anim.SetBool ("Opening", true);
		} else {
			anim.SetBool ("Opening", false);
		}
	}
}

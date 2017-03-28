using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    public void OnDoorClicked() {
        // If the door is clicked and unlocked
            // Set the "opening" boolean to true
        // (optionally) Else
            // Play a sound to indicate the door is locked
		if (GameManager.instance.Locked == false) {
			GameManager.instance.OpenDoor ();

            // sets the door inactive when the player get the key
            gameObject.SetActive (false);
		} else {
			GameManager.instance.DoorIsLocked ();
		}
    }
}

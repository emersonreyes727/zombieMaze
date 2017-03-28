using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab 
    [SerializeField] private GameObject poof;

	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
        transform.Rotate (new Vector3 (45, 0, 45) * Time.deltaTime);
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        // Set the Key Collected Variable to true
        // Destroy the key. Check the Unity documentation on how to use Destroy

        GameObject poofClone = (GameObject)Instantiate (poof, transform.position, transform.rotation);

        // calls the unlock method in the GameManager script
        GameManager.instance.Unlock ();

        // deactivates the key
        gameObject.SetActive (false);
    }

}

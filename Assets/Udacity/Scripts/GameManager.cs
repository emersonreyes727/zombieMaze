using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;

	// hides the reload and exit button when game begins
	[SerializeField] private GameObject reloadButton;
	[SerializeField] private GameObject exitButton;

	// for reload
	[SerializeField] private Transform cameraTransform;
	[SerializeField] private GameObject key;

	[SerializeField] private GameObject coinOne;
	[SerializeField] private GameObject coinTwo;
	[SerializeField] private GameObject coinThree;
	[SerializeField] private GameObject coinFour;
	[SerializeField] private GameObject coinFive;

	[SerializeField] private GameObject door;

	[SerializeField] private GameObject signPost;

	// for key sound
	private AudioSource audioSource;
	[SerializeField] private AudioClip keySoundFx;
	[SerializeField] private AudioClip coinSoundFx;

	// for door sound
	[SerializeField] private AudioClip doorLocked;
    [SerializeField] private AudioClip doorOpened;

	private bool locked = true;
	private bool playerHasKey = false;
	private bool opening = false;

	private int coins = 0;

	public bool Locked {
		get { return locked; }
	}

	public bool PlayerHasKey {
		get { return playerHasKey; }
	}

	public bool Opening {
		get { return opening; }
	}

	void Awake () {
		if (instance == null){
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		} 
	}

	// Use this for initialization
	void Start () {
		// hides the sign post, reload and exit button when game starts
		reloadButton.SetActive (false);
		exitButton.SetActive (false);
		signPost.SetActive (false);

		audioSource = GetComponent<AudioSource> ();
		
		Debug.Log ("Game Begins");
		Debug.Log ("Coins collected: " + coins);
		Debug.Log ("Player has the key: " + playerHasKey);
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void OpenDoor () {
		opening = true;

		// shows the reload and exit button when door opens
		reloadButton.SetActive (true);
		exitButton.SetActive (true);
		signPost.SetActive (true);

        audioSource.PlayOneShot (doorOpened);
	}

	public void DoorIsLocked () {
		audioSource.PlayOneShot (doorLocked);
	}

	public void Collect () {
		audioSource.PlayOneShot (coinSoundFx);

		coins += 1;
		Debug.Log ("Coins collected: " + coins);
	}

    public void Unlock()
    {
		audioSource.PlayOneShot (keySoundFx);

        // You'll need to set "locked" to false here
        locked = false;
		playerHasKey = true;

		Debug.Log ("Player has the key: " + playerHasKey);
    }

	public void GameReload () {
		// reset values
		locked = true;
		playerHasKey = false;
		opening = false;
		coins = 0;

		// move the camera to starting position
		cameraTransform.position = new Vector3 (-2.0f, 5.0f, 122.0f);

		// hides the reload and exit button when game re-starts
		reloadButton.SetActive (false);
		exitButton.SetActive (false);
		signPost.SetActive (false);
		
		// activates the coins and key
		key.SetActive (true);
		coinOne.SetActive (true);
		coinTwo.SetActive (true);
		coinThree.SetActive (true);
		coinFour.SetActive (true);
		coinFive.SetActive (true);

		// activates the door
		door.SetActive (true);

		Debug.Log ("Game Reloaded");
		Debug.Log ("Coins collected: " + coins);
		Debug.Log ("Player has the key: " + playerHasKey);
	}

	public void GameExit () {
		Application.Quit ();
	}
}

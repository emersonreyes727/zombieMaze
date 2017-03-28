using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMaker : MonoBehaviour {
	// will Instantiate the zombie GameObject
	[SerializeField] private GameObject zombie;

	// Use this for initialization
	void Start () {
		// zombie location
		Vector3[] zombiePosition = new [] {
            new Vector3 (-5.0f, 6.0f, 95.0f),
            new Vector3 (15.0f, 4.0f, 95.0f),
            new Vector3 (17.0f, 2.0f, 55.0f),
            new Vector3 (-14.0f, 5.0f, 74.0f),
            new Vector3 (-19.0f, 3.0f, 35.0f),
        };

		for (int i = 0; i < 5; i++) {
			GameObject zombieClone = (GameObject)Instantiate (zombie, zombiePosition[i], transform.rotation);
		}
	}
}

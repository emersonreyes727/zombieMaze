using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour {

	[SerializeField] private Transform mainCamera;

	private UnityEngine.AI.NavMeshAgent navMesh;
	private Animator anim;

	// Use this for initialization
	void Start () {
		navMesh = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		anim = GetComponent<Animator> ();	
	}
	
	// Update is called once per frame
	void Update () {
		// zombies will follow the main camera
		navMesh.SetDestination (mainCamera.position);	
	}
}

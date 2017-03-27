using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    // Create a reference to the CoinPoofPrefab
    [SerializeField] private GameObject poofPrefab;

    public void OnCoinClicked () {
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
       GameObject poofPrefabClone = (GameObject)Instantiate (poofPrefab, transform.position, transform.rotation);
       
       GameManager.instance.Collect ();

       // sets the coins inactive
       gameObject.SetActive (false);
    }
}

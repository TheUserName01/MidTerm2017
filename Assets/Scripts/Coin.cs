using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {
	private bool key = false;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "Character") {
			Debug.Log ("coin touched!!");
			key = true;
			if (key == true) {
				Debug.Log ("Key picked up!!");
				Destroy (gameObject);
			}

		}
	}


}

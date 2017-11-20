using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public Coin key;

	public GameObject currentCheckpoint;

	private NinjaControllerScript player;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<NinjaControllerScript> ();
		key = FindObjectOfType<Coin> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void RespawnPlayer()
	{
		Debug.Log ("Player Respawn");
		player.transform.position = currentCheckpoint.transform.position;
	}
}

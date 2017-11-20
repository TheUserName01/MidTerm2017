using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    //public GameObject player;

    //private Vector3 offset;

	// Use this for initialization
	//void Start () {
      //  offset = transform.position - player.transform.position;
	//}
	
	// Update is called once per frame
	//void LateUpdate () {
    //    transform.position = player.transform.position + offset;
	//}
	[SerializeField]
	Transform objectToFollow;

	[SerializeField]
	float yOffset;

	[SerializeField]
	float xOffset;

	[SerializeField]
	float cameraSpeed = 0.5f;

	float zOffset;

	void Start()
	{
		zOffset = transform.position.z;
	}

	void Update()
	{
		Vector3 newPosition = 
			new Vector3 (objectToFollow.position.x + xOffset, objectToFollow.position.y + yOffset, zOffset);

		Vector3 adjustPosition = Vector3.Lerp (transform.position, newPosition, cameraSpeed);

		transform.position = newPosition;
	}

}

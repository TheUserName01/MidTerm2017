using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelLoader : MonoBehaviour {

	//private bool playerInZone;

	public string sceneName;
	public Coin key;



	void Start () {
		key = FindObjectOfType<Coin> ();
		//key = false;
	}



        /// <summary>
        /// Use if statement asking  if key found then loadscene true, else false 
        /// </summary>
        /// <param name="other"></param>
	void OnTriggerEnter2D(Collider2D other)
	{
        //SceneManager.LoadScene(sceneName);
        Debug.Log ("SceneChaneTrigger has been triggered!");
		if(other.gameObject.name == "Character")
		{   
			Debug.Log ("key is true!");
			if (key == true)
			{
				Debug.Log("It was the player!");
				Debug.Log("Changing Scene to: " + sceneName);
				SceneManager.LoadScene(sceneName);
			}
		}
		//if (other.gameObject.name == "Character")
        //{
          //  Debug.Log("It was the player!");
            //Debug.Log("Changing Scene to: " + sceneName);
            //SceneManager.LoadScene(sceneName);
        //}
    }
		
	}




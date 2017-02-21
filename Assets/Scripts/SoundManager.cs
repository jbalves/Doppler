using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	[Header("References")]
	public SoundScroll soundPrefab;

	private GameObject cube;
	private soundPrefab sound;

	// Use this for initialization
	void Start () {
			cube = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		sound =  Instantiate(soundPrefab);
		//soundObject.transform.position = player.transform.position;
		
	}
}

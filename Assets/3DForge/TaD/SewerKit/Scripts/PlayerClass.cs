using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
		if (null == player) {
			GameObject playerObject = (GameObject)Instantiate(bombPrefab);
			bombObject.transform.position = this.gameObject.transform.position;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

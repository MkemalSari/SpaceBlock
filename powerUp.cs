using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour {


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y<-1045) {
			Destroy (gameObject);

		}
		

		
	}
}

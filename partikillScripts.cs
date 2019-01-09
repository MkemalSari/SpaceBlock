using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class partikillScripts : MonoBehaviour {


	void Start () {
		Invoke ("sil", 3f);
	}
	
	// Update is called once per frame
	void sil () {
		Destroy (gameObject);
	}
}

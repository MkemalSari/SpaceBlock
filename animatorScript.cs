using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorScript : MonoBehaviour {

	public static Animator anim;
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public static void animOynat(){

	//	anim.Play ("rekorAnim", -1, 0f);

	}
}

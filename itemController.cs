﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public	void anaEkranaDon(){
		gameObject.SetActive (false);
	}
	public	void skinEkranaDon(){
		gameObject.SetActive (true);
	}
}

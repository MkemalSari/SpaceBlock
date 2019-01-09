using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class playScript : MonoBehaviour {
	public  Button btnPlay;
	public  Button btnSes;
	public Button btnSkin;

	// Use this for initialization
	void Start () {
		btnPlay.onClick.AddListener (calistir);
		btnSes.onClick.AddListener (sesAyarla);
		btnSkin.onClick.AddListener (skinPanelAc);
	

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void calistir(){
        sonScript.tekhak = true;
		SceneManager.LoadScene ("SpaceBlock", LoadSceneMode.Single);
	}
	void sesAyarla(){
		

	}
	void skinPanelAc(){
		
	}
}

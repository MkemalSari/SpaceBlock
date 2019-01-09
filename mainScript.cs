using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class mainScript : MonoBehaviour {
	
	public Button btnPlay;
	void Start () {
		btnPlay.onClick.AddListener(calistir);
	}
	
	// Update is called once per frame
	void Update(){


	}
	void calistir(){
		Debug.Log("bastın");
		SceneManager.LoadScene("SpaceBlock", LoadSceneMode.Additive);
		btnPlay.gameObject.SetActive (false);
	}
		
}

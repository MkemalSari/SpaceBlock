using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mermi : MonoBehaviour {
	public GameObject partikil,obje;
	public Sprite[] mermiResimleri;
	public static int mermiID;
	Color renk;
	Text text;
	public int mermiGucu;

	void Start () {
		mermiID = misilleController.misilleResimId;
		mermiGucu = (PuanIslemleri.mermiGucu + ((PuanIslemleri.powerLvl+1) * 5));
		GetComponent<SpriteRenderer> ().sprite = mermiResimleri[mermiID];
	}
	void fixedUpdate(){

       

    }
	
	// Update is called once per frame
	void Update () {
       

        transform.Translate (new Vector3 (0,20f));
		if (transform.position.y>=1000) {
			Destroy (gameObject);

		}
		
	}

	void OnTriggerEnter2D(Collider2D temas){
		if (temas.gameObject.tag=="Mermi") {
			// puan İşelemleri değiştirdim  PuanIslemleri.Puan +=mermiGucu;
			animatorScript.animOynat ();
			text=temas.transform.GetComponentInChildren<Text>();
			int sayi = int.Parse (text.text);
			renk=temas.gameObject.GetComponent<Renderer> ().material.color;
			 Instantiate (partikil, temas.transform.position, Quaternion.identity).GetComponent<Renderer> ().material.color = renk;

			if ((sayi - mermiGucu)> 0) {
				text.text = (sayi - mermiGucu).ToString ();

		
			} else {

				temas.gameObject.SetActive (false);

			}
			Destroy (gameObject);

		

		}

	}


}

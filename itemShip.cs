using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemShip : MonoBehaviour {

	Button secilen;
	Image secilenResim;
	Text btnText;
	void Start () {

		secilen= gameObject.GetComponentInChildren<Button> ();
		btnText= secilen.GetComponentInChildren<Text> ();
		secilen.onClick.AddListener (itemSec);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void itemSec(){
		SecimleriSil ();
		btnText.text = "Seçildi";
		PlayerPrefs.SetInt ("ucakID",int.Parse(secilen.name));


	}
	 void SecimleriSil () {
		for (int i = 0; i <shipsController.dizi.Length; i++) {
			shipsController.dizi [i].text = "Seç";
		}

	}
}

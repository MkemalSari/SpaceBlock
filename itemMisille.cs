using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemMisille : MonoBehaviour {

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
		misilleController.misilleResimId = int.Parse(secilen.name);
		PlayerPrefs.SetInt ("mermiID",int.Parse(secilen.name));


	}
	void SecimleriSil () {
		for (int i = 0; i <misilleController.dizi.Length; i++) {
			misilleController.dizi [i].text = "Seç";
		}

	}
}

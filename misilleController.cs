using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class misilleController : MonoBehaviour {

	// Use this for initialization
	public static Text[] dizi;
	public static int misilleResimId;
	// Use this for initialization
	void Start () {
		misilleResimId=PlayerPrefs.GetInt ("mermiID");
		dizi = transform.GetComponentsInChildren<Text> ();
		dizi[misilleResimId].text="Seçildi";
	}

	// Update is called once per frame


}

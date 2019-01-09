using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shipsController : MonoBehaviour {
	public static Text[] dizi;
	public static int ucakResimId;
	// Use this for initialization
	void Start () {
		ucakResimId=PlayerPrefs.GetInt ("ucakID");
		 dizi = transform.GetComponentsInChildren<Text> ();
		dizi[ucakResimId].text="Seçildi";
		}
	
	// Update is called once per frame


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuanIslemleri : MonoBehaviour {

	public static int Puan=1,rekorPuan=0,moneyDeger=0,powerLvl=0,speedLvl=0,mermiGucu=20,sayac;
	public static float mermiHizi=0.4f;
	public Text text;
	public Text money;
	public Text rekorText,shotPowerLvl,shotSpeedLvl;
	public GameObject multiPower,gucPower;
	public static float satirHizlari;
	float sn,sn1;

	// Use this for initialization
	void Start () {
		satirHizlari = -7.5f;
		rekorPuan=PlayerPrefs.GetInt("rekor");
		moneyDeger = PlayerPrefs.GetInt ("money");
		powerLvl = PlayerPrefs.GetInt ("power");
		speedLvl = PlayerPrefs.GetInt ("speed");
		
	}
	
	// Update is called once per frame
	void Update () {
		shotPowerLvl.text = powerLvl.ToString ();
		shotSpeedLvl.text = speedLvl.ToString ();
		money.text = moneyDeger.ToString ();

		sn += Time.deltaTime;
		if (sn>=13f) {
			float rdn= Random.Range (-500, 500);
			Instantiate (multiPower, new Vector3 (rdn, 1000,-1), Quaternion.identity);
			sn = 0;
		}
		sn1 += Time.deltaTime;
		if (sn1>=17f) {
			float rdn= Random.Range (-500, 500);
			Instantiate (gucPower, new Vector3 (rdn, 1000,-1), Quaternion.identity);
			sn1 = 0;
		}



	}
	void FixedUpdate (){
		rekorPuan=PlayerPrefs.GetInt("rekor");
		moneyDeger = PlayerPrefs.GetInt ("money");
		powerLvl = PlayerPrefs.GetInt ("power");
		speedLvl = PlayerPrefs.GetInt ("speed");
		text.text = Puan.ToString();
		rekorText.text = rekorPuan.ToString ();



	}
}

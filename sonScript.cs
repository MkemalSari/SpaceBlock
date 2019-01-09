using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;

public class sonScript : MonoBehaviour {
	public static Text rekor;
	public Button btnYenidenOyna;
	public Button btnShotSpeed;
	public Button btnShotPower;
	public Button reset;
	public Button btnRestart;
    public static GameObject panel;
	public static bool tekhak=true;

	// Use this for initialization
	void Start () {

        panel = gameObject;
		gameObject.SetActive (false);
		btnYenidenOyna.onClick.AddListener (yenidenOyna);
		btnShotSpeed.onClick.AddListener (hizArttir);
		btnShotPower.onClick.AddListener (gucArttir);
		btnRestart.onClick.AddListener (restartAt);
		reset.onClick.AddListener (resetAt);
		//reklamScript =	FindObjectOfType<ReklamScript> ();


	}
	void Update(){
		btnYenidenOyna.gameObject.SetActive (tekhak);
        btnYenidenOyna.gameObject.SetActive(ReklamScript.RewardedReklamHazirMi()); 


        if (PuanIslemleri.moneyDeger >= 50) {//power up Ucreti
			btnShotSpeed.enabled = true;
		} else {
			btnShotSpeed.enabled = false;
		}
		if (PuanIslemleri.moneyDeger >= 50) {//power up Ucreti
			btnShotPower.enabled = true;
		} else {
			btnShotPower.enabled = false;
		}


	}
	void fixedUpdate () {
		rekor.text = PuanIslemleri.rekorPuan.ToString ();


	

		
	}
	
	void yenidenOyna(){
	

		ReklamScript.RewardedReklamGoster (odullendir);
	


	}
	void hizArttir(){
		
		PuanIslemleri.moneyDeger -= 10;//power up Ucreti
			PuanIslemleri.speedLvl ++;
			PlayerPrefs.SetInt ("speed", PuanIslemleri.speedLvl);
		} 

	void gucArttir(){
		PuanIslemleri.moneyDeger -= 10;//power up Ucreti
		PuanIslemleri.powerLvl ++;
		PlayerPrefs.SetInt ("power", PuanIslemleri.powerLvl);

	}
	void resetAt(){
		PuanIslemleri.rekorPuan = 0;
		PuanIslemleri.moneyDeger = 0;
		PuanIslemleri.powerLvl = 0;
		PuanIslemleri.speedLvl = 0;
		PlayerPrefs.SetInt ("power", 0);
		PlayerPrefs.SetInt ("speed", 0);
		PlayerPrefs.SetInt ("money", 0);
        PlayerPrefs.SetInt("rekor", 0);

    }
	void restartAt (){
		ReklamScript.yanmaSayisi++;
		if (ReklamScript.yanmaSayisi%2==0) {
			ReklamScript.InsterstitialGoster();
		}
		tekhak = true;
		PuanIslemleri.Puan = 0;
		SceneManager.LoadScene ("Play", LoadSceneMode.Single);
		Time.timeScale = 1;
	}

    public void odullendir( Reward args)
    {
        panel.SetActive(false);
        Time.timeScale = 1;
        tekhak = false;
        MonoBehaviour.print(
            "HandleRewardBasedVideoRewarded event received for ");
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cracter : MonoBehaviour {
	public Sprite[] ucakResimleri;
	public static Sprite ucakResmi;
	public GameObject sonScene;
	public static float hiz=25f,mermiHizi2;
	float sn,powerUpSuresi;
	public GameObject mermi,buyukMermi;
	bool powerUpUclu=false,powerUpGuc;
	void Start () {
		GetComponent<SpriteRenderer> ().sprite = ucakResimleri[PlayerPrefs.GetInt ("ucakID")];

	}

	
	// Update is called once per frame
	void Update () {

		float mermiHizi1 = (PuanIslemleri.mermiHizi -( PuanIslemleri.speedLvl * 0.01f));
		//int mermiGucu = (PuanIslemleri.mermiGucu + (PuanIslemleri.powerLvl * 5));

		sn += Time.deltaTime;

		if (Time.timeScale==1) {
			
		
				
			
		if (Input.touchCount > 0) 
		{
			Touch touch = Input.GetTouch(0); // get first touch since touch count is greater than zero

			if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved) 
			{
				// get the touch position from the screen touch to world point
				Vector3 touchedPos = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x,touch.position.y));
				// lerp and set the position of the current object to that of the touch, but smoothly over time.
				transform.position = Vector3.Lerp((new Vector3(transform.position.x,transform.position.y,-1)),new Vector3(touchedPos.x,transform.position.y,-1), Time.deltaTime*10);
			}
		}



		transform.Translate (Input.GetAxis ("Horizontal") * Vector3.right * hiz);
	
			
		

		//Mermi ayarları
		if (powerUpUclu==true) {
				if (sn>=mermiHizi1) {	
				GetComponents<AudioSource> () [1].Play ();
				Instantiate (mermi, new Vector3 (transform.position.x, -340,-1), Quaternion.identity);
				Instantiate (mermi, new Vector3 (transform.position.x+150, -340,-1), Quaternion.identity);
				Instantiate (mermi, new Vector3 (transform.position.x-150, -340,-1), Quaternion.identity);


				sn = 0;
			}

			powerUpSuresi += Time.deltaTime;

			if (powerUpSuresi>=5f) {
				powerUpUclu = false;
				powerUpSuresi = 0;
			}
		} 
		else if (powerUpGuc==true) {
                PuanIslemleri.mermiGucu = 100;
			powerUpSuresi += Time.deltaTime;
			if (sn>=mermiHizi1) {	
				GetComponents<AudioSource> () [2].Play ();
                    mermi.transform.localScale = new Vector3(400.0f, 400.0f, 2.0f);
                    Instantiate (mermi, new Vector3 (transform.position.x, -340,-1), Quaternion.identity);

				sn = 0;
			}

			if (powerUpSuresi>=5f) {
                    PuanIslemleri.mermiGucu = 20;
                    mermi.transform.localScale = new Vector3(200.0f, 200.0f, 2.0f);
                    powerUpGuc = false;
				powerUpSuresi = 0;
			}
		}


		else {

			if (sn>=mermiHizi1) {	
				GetComponents<AudioSource> () [0].Play ();
                    mermi.transform.localScale = new Vector3(200.0f, 200.0f, 2.0f);
                    Instantiate (mermi, new Vector3 (transform.position.x, -340,-1), Quaternion.identity);

				sn = 0;
			}
		}

		}

	}

	//Uzay gemisinin temaslarını kontrol ediyoruz.
	void OnTriggerEnter2D(Collider2D temas){
		if (temas.gameObject.tag=="multiStrike") {
			Destroy (temas.gameObject);
			powerUpUclu = true;
		}
		if (temas.gameObject.tag=="powerUp") {
			Destroy (temas.gameObject);
			powerUpGuc = true;
		}
		if (temas.gameObject.tag=="Mermi") {
			temas.gameObject.SetActive (false);
			PuanIslemleri.moneyDeger += PuanIslemleri.Puan;
			PlayerPrefs.SetInt ("money", PuanIslemleri.moneyDeger);
			if (PuanIslemleri.rekorPuan<PuanIslemleri.Puan) {
				PlayerPrefs.SetInt ("rekor", PuanIslemleri.Puan);


			}
			Time.timeScale = 0;
			sonScene.SetActive (true);

		}
	}


}

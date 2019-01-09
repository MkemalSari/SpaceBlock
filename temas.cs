using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class temas : MonoBehaviour {


	Color32 kolay=new Color32(164,235,57,255),orta=new Color32(70,227,206,255),zor=new Color32(224,86,55,255),enZor=new Color32(203,57,222,255);
	Text text;
	public static int puan;
     public int zorlukSeviyesi = 25;
	int sayac;



	// Update is called once per frame
	void Update () {
		


		int[] zorluk = zorlukScript.zorlukSeviyesi (zorlukSeviyesi);
		if (Time.timeScale!=0) {
			
			transform.Translate (new Vector3 (0, PuanIslemleri.satirHizlari));
		for (int i = 0; i < 5; i++) {
			text = transform.GetChild (i).GetComponentInChildren<Text> ();
			int number =int.Parse (text.text);
				if (number <= zorluk[1]) {
				transform.GetChild (i).GetComponent<Renderer> ().material.color = kolay;
				} else if (number > zorluk[1] && number <= zorluk[4]) {
				transform.GetChild (i).GetComponent<Renderer> ().material.color = orta;
				} else if (number > zorluk[4] && number <= zorluk[7]) {
				transform.GetChild (i).GetComponent<Renderer> ().material.color = zor;
				} else if (number > zorluk[7] && number <= zorluk[9]) {
				transform.GetChild (i).GetComponent<Renderer> ().material.color = enZor;
			}

		}
		}
	}
	void OnTriggerEnter2D(Collider2D temp ){
		if (temp.gameObject.tag=="Tetik") {
			
			transform.position = new Vector3 (-29, 3500,-1);

		}
		if (temp.gameObject.tag=="tetikGiris") {
			
			sayac++;
			if (sayac%5==0) {
				zorlukArttır ();
			}
			for (int i = 0; i < 5; i++) {
				text=transform.GetChild(i).GetComponentInChildren<Text>();
                int[] dizi = zorlukScript.zorlukSeviyesi(zorlukSeviyesi);
				var number =  dizi[Random.Range (0, 9)];

				text.text = number.ToString ();

				transform.GetChild (i).gameObject.SetActive(true);


			}


		}

	}
	void zorlukArttır(){

			zorlukSeviyesi += 25;
		PuanIslemleri.satirHizlari -= 1f;

	}



	
}

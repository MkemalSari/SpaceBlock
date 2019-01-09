using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkorController : MonoBehaviour {

    public Text skor;
   public int skorDegeri;
	void Start () {
        skorDegeri = 1;
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.timeScale != 0)
        {
            skor.transform.Translate(new Vector3(0, PuanIslemleri.satirHizlari));
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Tetik")
        {
            
            skor.transform.Translate(0, 3000,0);
            PuanIslemleri.Puan++;
            skorDegeri++;
        }
    }

    private void FixedUpdate()
    {
        skor.text = skorDegeri.ToString();
    }
}

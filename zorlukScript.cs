using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class zorlukScript : MonoBehaviour {

	public static int[] zorlukSeviyesi(int sayi){
		//int zorlukBelirleyici =(PuanIslemleri.powerLvl+PuanIslemleri.speedLvl);

		int[] zorluk = new int[10];
		for (int i = 0; i < 10; i++) {
			
				sayi += 10;
            zorluk[i] = sayi;
        }

        return zorluk;

    }
		
	}


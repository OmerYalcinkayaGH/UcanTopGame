using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class puan : MonoBehaviour {
 static int puanlama;
public bool baslangic;
public Text puanmetni;
	// Use this for initialization
	void Start ()
	 {
		if	(baslangic==true)		
		{
		puanlama=0;
		baslangic=false;		
		}
	}
	public void puanalma(int p)	
	{		
    puanlama=puanlama+p;
	puanmetni.text="Puan:"+puanlama.ToString();
	}
	public void puangöster()
	{
	puanmetni.text="Puan:"+puanlama.ToString();
	}
	// Update is called once per frame


}
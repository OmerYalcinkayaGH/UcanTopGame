using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
public class altkısımcode : MonoBehaviour {

	// Use this for initialization
		private sahnegecis sg;
		public topcode tp;
  public Text can;
  public bool bolum;
  static int canhakkı=3;
	void OnTriggerEnter2D(Collider2D trigger){		
	if	(canhakkı<=0)
	{
		Thread.Sleep(1000);
		sg=GameObject.FindObjectOfType<sahnegecis>();
		sg.gecis("gameover");
	}	
	Thread.Sleep(500);
	tp.baslangic();
		canhakkı--;
		
	can.text=canhakkı.ToString();
	}
	public void canbasma()
	{
		canhakkı++;
		Debug.Log ("canbasma basıldı.");
		Debug.Log(canhakkı.ToString());
		can.text=canhakkı.ToString();
	}
	public void cangöster()
	{
		can.text=canhakkı.ToString();
	}
void Start () {
	
		if(bolum==true)
	{
		can.text=canhakkı.ToString();
        canhakkı=3;
		bolum=false;
	}
	}

	}
   


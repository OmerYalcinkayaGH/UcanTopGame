using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class tugla4code : MonoBehaviour {

public int maxcarpma;
static int count=0;
private sahnegecis sg ;
private int carpmasay;
private altkısımcode ac;
private puan pn;
public bool hediye1;
public bool hediye2;
public Sprite resim;


		// Use this for initialization
		void OnCollisionEnter2D(Collision2D collision)
		{
  	
        pn=GameObject.FindObjectOfType<puan>();		
        pn.puanalma(50);
	carpmasay++;
	{
	if(carpmasay==maxcarpma-1)
	{		
		this.gameObject.GetComponent<SpriteRenderer>().sprite=resim;		
	}
	else{
	 if (hediye1==true)
	{	
		ac=GameObject.FindObjectOfType<altkısımcode>();
		ac.canbasma();
	}
     
	else if(hediye2==true)
	{
		Debug.Log("hediye2");
	 pn.puanalma(200);
	}
	Destroy(gameObject);
	Debug.Log("yok etme metodu");
	}	     
	}
	Debug.Log(count.ToString());
	if(count>=23)
	{ 		
		sg=GameObject.FindObjectOfType<sahnegecis>();
		sg.gecis("level05");
	}
	count++;
		}
		void Start () {
			    pn=GameObject.FindObjectOfType<puan>();		
                pn.puangöster();
				   ac=GameObject.FindObjectOfType<altkısımcode>();		
              ac.cangöster();

		}
		}

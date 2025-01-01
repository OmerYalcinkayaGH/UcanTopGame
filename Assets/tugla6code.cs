using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tugla6code : MonoBehaviour {

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
		{;
        pn=GameObject.FindObjectOfType<puan>();	
       
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
		pn=GameObject.FindObjectOfType<puan>();		
        pn.puanalma(200);
	}
	else
		{
			pn.puanalma(50);
		}
	Destroy(gameObject);
	 Debug.Log("yok etme metodu");
	}
     
	}
	Debug.Log(count.ToString());
	if(count>=31)
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



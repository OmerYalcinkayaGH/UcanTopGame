using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using System;

public class tugla3code : MonoBehaviour {

static int count=0;
private sahnegecis sg ;
private puan pn;
private altkısımcode ac;
		void OnCollisionEnter2D(Collision2D collision)
		{
		pn=GameObject.FindObjectOfType<puan>();		
		pn.puanalma(50);		
		Destroy(gameObject);
		count++;
		if(count>=21)
		{ 		
			sg=GameObject.FindObjectOfType<sahnegecis>();
			sg.gecis("level04");
		}	
			}
			void Start () {
				pn=GameObject.FindObjectOfType<puan>();		
                pn.puangöster();
				ac=GameObject.FindObjectOfType<altkısımcode>();		
                ac.cangöster();
			}		
		
			void Update () {	
				

			}


}

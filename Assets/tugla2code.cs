using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class tugla2code : MonoBehaviour {

static int count=0;
private sahnegecis sg ;
private puan pn;
private altkısımcode ac;
	// Use this for initialization
	void OnCollisionEnter2D(Collision2D collision)
	{    
    pn=GameObject.FindObjectOfType<puan>();		
    pn.puanalma(50);
	Destroy(gameObject); 
	Debug.Log(count.ToString());
	if(count>=11)
	{ 
	sg=GameObject.FindObjectOfType<sahnegecis>();
	sg.gecis("level03");
	}
	count++;
		}
		void Start () {
			    pn=GameObject.FindObjectOfType<puan>();		
                pn.puangöster();
				   ac=GameObject.FindObjectOfType<altkısımcode>();		
              ac.cangöster();

		}
		
		// Update is called once per frame
		void Update () {
			
		}
	}


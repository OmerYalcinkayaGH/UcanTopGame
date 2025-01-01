using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class tuglacode : MonoBehaviour {
private int maxcarpma;
static int count=0;
private sahnegecis sg ;
private puan pn;

		// Use this for initialization
		void OnCollisionEnter2D(Collision2D collision)
		{		pn=GameObject.FindObjectOfType<puan>();

		
        pn.puanalma(100);
		Destroy(gameObject);
	Debug.Log(count.ToString());
	if(count>=5)
	{ 		
		sg=GameObject.FindObjectOfType<sahnegecis>();
		sg.gecis("level02");
	}
	count++;
		}
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {
			
		}
	}

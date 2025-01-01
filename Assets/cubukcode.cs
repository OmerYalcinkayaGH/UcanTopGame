using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubukcode : MonoBehaviour {


private cubukcode hareket;
	// Use this for initialization
	void Start () {
		

	}

	// Update is called once per frame
	void klavyehareket()
	{
    if(this.transform.position.x>29)
	{
	 if (Input.GetKey(KeyCode.LeftArrow))
	{
		transform.Translate(-17,0,0);
	}
	
	}
	if	(this.transform.position.x<967)
	{
	if(Input.GetKey(KeyCode.RightArrow))
	{
	transform.Translate(17,0,0);	
	
	}
	}
	
	}
	void Update () {
	klavyehareket();

	}
	void OnCollisionEnter2D(Collision2D collision)
	{
		GetComponent<AudioSource>().Play();
	}
}

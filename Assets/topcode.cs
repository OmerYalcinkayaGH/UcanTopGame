using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topcode : MonoBehaviour {

	private cubukcode cubuk;
	private bool basla=false;
	private Vector3 pozisyon;//Çubuk ile top arasındaki uzaklık belirleyecek
	void Start () {
	cubuk=GameObject.FindObjectOfType<cubukcode>();
	pozisyon=this.transform.position-cubuk.transform.position;
	}
	public void baslangic()
	
	{
	  	
	 basla=false;
		Debug.Log("baslangic");
	}
	
	void Update () {
		if (basla==false)
		{
		Debug.Log("Update metodu");	    
        this.transform.position=cubuk.transform.position+pozisyon;
		}
		if(Input.GetKey(KeyCode.Space))
		{
		basla=true;
		this.GetComponent<Rigidbody2D>().velocity=new Vector2(300f,900f);
		}
	}
}

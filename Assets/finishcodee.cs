using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.SceneManagement;
public class finishcodee : MonoBehaviour {

	// Use this for initialization
int a=0;
void Update () {
			Thread.Sleep(500);
			a++;
		if(a==10)		
		{
		SceneManager.LoadScene("giris");			
		}
		}

}

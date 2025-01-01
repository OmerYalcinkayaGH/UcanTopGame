using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;
public class sahnegecis : MonoBehaviour {

	public void gecis(string sahneismi)
	{
Thread.Sleep(500);
	Debug.Log("gecise basıldı."+sahneismi);
	SceneManager.LoadScene(sahneismi);
	}
	public void cikis()
	{
		Application.Quit();
	Debug.Log("ÇIKIŞA BASILDI.");
	}

}

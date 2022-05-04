using UnityEngine;
using System.Collections;

public class PowerUP : MonoBehaviour {

	public GameObject CronometroGO;
	public Cronometro cronometroScript;

	void Start()
	{
		CronometroGO= GameObject.Find ("Cronometro");
		cronometroScript = CronometroGO.GetComponent<Cronometro>();
	}

	void OnTriggerEnter2D (Collider2D cInfo)
	{
		if(cInfo.gameObject.tag == "Coche")
		{
			cronometroScript.tiempo +=10;
			cronometroScript.ImagenMasTiempo();
			gameObject.SetActive(false);
		}
	}
}

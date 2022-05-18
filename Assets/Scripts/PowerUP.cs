using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUP : MonoBehaviour
{

	public GameObject CronometroGO;
	public Cronometro cronometroScript;

	void Start()
	{
		CronometroGO = GameObject.Find ("Cronometro");
		cronometroScript = CronometroGO.GetComponent<Cronometro>();
	}


   void OnTriggerEnter2D (Collider2D cInfo)
	{
		if(cInfo.gameObject.tag == "Coche")
		{
			cronometroScript.tiempo +=10;
			gameObject.SetActive(false);
		}
	}
}

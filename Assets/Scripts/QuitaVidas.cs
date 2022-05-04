using UnityEngine;
using System.Collections;

public class QuitaVidas : MonoBehaviour {

	public GameObject VidasGO;
	public Vidas vidasScript;

	void Start()
	{
		VidasGO = GameObject.Find("Vidas");
		vidasScript = VidasGO.GetComponent<Vidas>();
	}

	void OnTriggerEnter2D(Collider2D cInfo)
	{
		if (cInfo.gameObject.tag == "Coche")
		{
			vidasScript.contadorVidas = vidasScript.contadorVidas -1;
			vidasScript.ImagenMenosVida();
			gameObject.SetActive(false);
		}
	}

}

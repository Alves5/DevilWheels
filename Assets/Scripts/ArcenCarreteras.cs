using UnityEngine;
using System.Collections;

public class ArcenCarreteras : MonoBehaviour {


	// Declaro las variables y todos los objetos que voy a utilizar
	public GameObject motorCarretera;
	public MotorCarreteras motorCarreterasScript;
	public GameObject coche;

	void Start()
	{	
		// Busco la referencias declaradas con la funcion start
		motorCarretera = GameObject.Find ("MotorCarreteras");
		motorCarreterasScript = motorCarretera.GetComponent<MotorCarreteras>();
	}

	void OnTriggerEnter2D(Collider2D cInfo)
	{
		//Compruebo que entro en el collider con el coche
		if(cInfo.gameObject.tag == "Coche")
		{
			motorCarreterasScript.SpeedArcen();
			coche.GetComponent<AudioSource>().pitch = 1f;
		}
	}

	void OnTriggerExit2D(Collider2D cInfo)
	{
		//Compruebo que salgo del collider con el coche
		if (cInfo.gameObject.tag == "Coche")
		{
			motorCarreterasScript.SpeedCarretera();
			coche.GetComponent<AudioSource>().pitch = 1.6f;
		}
	}
	
}

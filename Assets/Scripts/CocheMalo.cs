using UnityEngine;
using System.Collections;

public class CocheMalo : MonoBehaviour {

	// Declaro las variables y todos los objetos que voy a utilizar
	public GameObject motorCarretera;
	public MotorCarreteras motorCarreterasScript;
	public GameObject coche;


	void Start()
	{
		// Busco la referencias declaradas con la funcion start
		motorCarretera= GameObject.Find ("MotorCarreteras");
		motorCarreterasScript = motorCarretera.GetComponent<MotorCarreteras>();
		coche= GameObject.Find ("Coche");
	}


	void OnCollisionEnter2D(Collision2D cInfo)
	{
		//Compruebo que hay una collision con el collider con el coche
		if(cInfo.gameObject.tag == "Coche")
		{
			Debug.Log ("Entro");
			motorCarreterasScript.SpeedCocheMalo();
			coche.GetComponent<AudioSource>().pitch = 1f;
			this.gameObject.GetComponent<AudioSource>().Play();
		}

	}
	
	void OnCollisionExit2D(Collision2D cInfo)
	{
		//Compruebo que termino la collision del collider con el coche
		if (cInfo.gameObject.tag == "Coche")
		{
			Debug.Log ("Entro");
			motorCarreterasScript.SpeedCarretera();
			coche.GetComponent<AudioSource>().pitch = 1.6f;
		}
	}


}

using UnityEngine;
using System.Collections;

public class BorrarPreferencias : MonoBehaviour {

	// Use this for initialization
	void Awake () {

		// Borro preferencias que pueda haber creado unity por defecto
		PlayerPrefs.DeleteAll();
	
	}
	

}

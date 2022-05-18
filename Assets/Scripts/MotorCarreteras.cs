using UnityEngine;
using System.Collections;

public class MotorCarreteras : MonoBehaviour {

// Declaro las variables y todos los objetos que voy a utilizar

	public GameObject motorCarreteras;
	public GameObject[] contenedorCalles;

	public float speed;

	public int numSelector = 0;
	public int numSelectorDeCalle;
	public int contadorCalles = 0;

	public bool cuentaRegresivaTermino;
	public bool juegoTerminado;
	public GameObject imagenFundido;

	// Use this for initialization
	void Start () {
		juegoTerminado = false;
		InicioJuego();
	}

	public void InicioJuego()
	{
		CreaCalles();
		SpeedCarretera();
		cuentaRegresivaTermino = false;
		imagenFundido.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

		if(cuentaRegresivaTermino && juegoTerminado == false)
		{
			// Muevo todas el padre de todas las calles hacia abajo (en Y)
			motorCarreteras.transform.Translate(Vector3.down * speed * Time.deltaTime);
		}

	
	}

	// SIstema de creacion de calles
	public void CreaCalles()
	{
		if(numSelector >= 0 && numSelector <= 6)
		{
			numSelector++;
			numSelectorDeCalle = numSelector;

			GameObject Calle = (GameObject)Instantiate(contenedorCalles[numSelectorDeCalle],
													new Vector3(0,50,0),
													transform.rotation);
			Calle.SetActive(true);
			contadorCalles ++;
			Calle.name = "Calle"+contadorCalles;
			Calle.transform.parent = motorCarreteras.transform;

			GameObject piezaAux = GameObject.Find ("Calle"+(contadorCalles-1));

			Calle.transform.position = new Vector3( transform.position.x,
												piezaAux.GetComponent<Renderer>().bounds.size.y +
												piezaAux.transform.position.y,
												piezaAux.transform.position.z);
		}else{
			numSelector = 1;
			numSelectorDeCalle = numSelector;

			GameObject Calle = (GameObject)Instantiate(contenedorCalles[numSelectorDeCalle],
													new Vector3(0,50,0),
													transform.rotation);
			Calle.SetActive(true);
			contadorCalles ++;
			Calle.name = "Calle"+contadorCalles;
			Calle.transform.parent = motorCarreteras.transform;

			GameObject piezaAux = GameObject.Find ("Calle"+(contadorCalles-1));

			Calle.transform.position = new Vector3( transform.position.x,
												piezaAux.GetComponent<Renderer>().bounds.size.y +
												piezaAux.transform.position.y,
												piezaAux.transform.position.z);
		}
		

	}

	// diferentes opciones de velocidad para acceder desde otros scripts
	public void SpeedStop()
	{
		speed = 0;
	}

	public void SpeedArcen()
	{
		speed = 5;
	}

	public void SpeedCarretera()
	{
		speed = 15;
	}

	public void SpeedCocheMalo()
	{
		speed = 3;
	}

	public void FinalizarJuego()
	{
		SpeedStop();
	}

}












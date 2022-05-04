using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Vidas : MonoBehaviour {

	public GameObject[] vidas;
	public int contadorVidas = 3;
	public GameObject popGameOverGO;
	public PopGameOver popGameOverScript;
	public GameObject motorCarretera;
	public MotorCarreteras motorCarreterasScript;
	public Cronometro cronometroScript;
	public Image menosVida;

	// Use this for initialization
	void Start () {
		menosVida.CrossFadeAlpha(0,0,false);
	}
	
	// Update is called once per frame
	void Update () {

		if (contadorVidas == 2 && motorCarreterasScript.juegoTerminado == false)
		{
			vidas[2].SetActive(false);
		}
		if(contadorVidas == 1)
		{
			vidas[1].SetActive(false);
		}
		if (contadorVidas == 0 && motorCarreterasScript.juegoTerminado == false)
		{
			vidas[0].SetActive(false);
			motorCarreterasScript.juegoTerminado = true;
			cronometroScript.cronometroEncendido = false;
			popGameOverGO.SetActive(true);
			popGameOverScript.ActivoGameOver();
		}
	
	}

	public void ImagenMenosVida()
	{
		if(contadorVidas >= 1)
		{
			menosVida.CrossFadeAlpha(1,0.5f,false);
			this.gameObject.GetComponent<AudioSource>().Play ();
			StartCoroutine(CierroImagenMenosVida());
		}
	}

	IEnumerator CierroImagenMenosVida()
	{
		yield return new WaitForSeconds(1);
		menosVida.CrossFadeAlpha(0,0.5f,false);

	}
}


















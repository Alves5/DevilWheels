using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuentaAtras : MonoBehaviour
{
   	public GameObject motorCarreteras;
	public GameObject musicaJuego;
	public GameObject sonidoStart;
	public GameObject sonidoMotorCoche;
	public GameObject numeros;
	public Sprite[] numerosIMG;

	public MotorCarreteras motorCarreteraScript;
	public Cronometro cronometroScript;

	float tiempoDeEspera = 4;

	public bool pararCuenta = false;
	public bool finContador = false;

    public AudioSource reproductor;
	public AudioClip[] sonidosContador;

	void Start()
	{
		// Le digo que reproductor hace referencia al audioSource que tiene 
		// el GameObject que contiene este script
		reproductor = this.gameObject.GetComponent<AudioSource>();
		IniciarCuentaAtras();

	}

	public void IniciarCuentaAtras()
	{
		StartCoroutine(EmpezarCuentaAtras());
	}

	public IEnumerator EmpezarCuentaAtras()
	{
		sonidoStart.GetComponent<AudioSource>().Play();

		yield return new WaitForSeconds(1);

		InvokeRepeating("Contando",1.0f,1.0f);
	}

	void Contando()
	{
		tiempoDeEspera --;

		if(tiempoDeEspera >= 3)
		{
			numeros.GetComponent<SpriteRenderer>().sprite = numerosIMG[3];
			reproductor.clip = sonidosContador[0];
			reproductor.Play();
		}
		if(tiempoDeEspera <= 3 && tiempoDeEspera >=2)
		{
			numeros.GetComponent<SpriteRenderer>().sprite = numerosIMG[2];
			reproductor.clip = sonidosContador[0];
			reproductor.Play();
		}
		if(tiempoDeEspera <= 2 && tiempoDeEspera >=1)
		{
			numeros.GetComponent<SpriteRenderer>().sprite = numerosIMG[1];
			reproductor.clip = sonidosContador[0];
			reproductor.Play();
		}
		if (tiempoDeEspera <= 1 && finContador == false)
		{
			finContador =true;
			cronometroScript.cronometroEncendido = true;
			motorCarreteraScript.cuentaRegresivaTermino = true; 
			numeros.GetComponent<SpriteRenderer>().sprite = numerosIMG[0];
			reproductor.clip = sonidosContador[1];
			reproductor.Play();

			musicaJuego.GetComponent<AudioSource>().Play();
			sonidoMotorCoche.GetComponent<AudioSource>().Play();
		}

		if (tiempoDeEspera <= 0)
		{
			CancelInvoke();
		}
	}

		void Update()
	{
		if (tiempoDeEspera == 0 && pararCuenta == false)
		{
			pararCuenta = true;
			numeros.SetActive(false);
		}
	}
}

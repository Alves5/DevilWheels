using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour
{
  public GameObject motorCarretera;
	public MotorCarreteras motorCarreterasScript;

	public Text textoTiempo;
	public Text textoMetros;

	public float distancia;
	public float tiempo;

	public bool cronometroEncendido;

    public Image masTiempo;

	public GameObject popGameOverGO;
	public PopGameOver popGameOverScript;

	void Start () 
	{
	    textoTiempo.text = "1:30";
		textoMetros.text = "0";
        masTiempo.CrossFadeAlpha(0,0,false);
	}
	
	void Update () 
	{
        if (motorCarreterasScript.juegoTerminado == false && cronometroEncendido == true)
            {
                distancia += Time.deltaTime * motorCarreterasScript.speed;
                textoMetros.text = ((int)distancia).ToString();

                tiempo -= Time.deltaTime;
                int minutos = (int)tiempo/60;
                int segundos = (int)tiempo%60;

                textoTiempo.text = minutos.ToString() +
                                    ":" +
                        segundos.ToString().PadLeft(2,'0');
            }

        if(tiempo <= 0.00f && motorCarreterasScript.juegoTerminado == false)
		{
			motorCarreterasScript.juegoTerminado = true;
			popGameOverGO.SetActive(true);
			popGameOverScript.ActivoGameOver();
		}
	}

}

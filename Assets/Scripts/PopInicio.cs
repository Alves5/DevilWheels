using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PopInicio : MonoBehaviour {

	public Image BGpop;
	public Image imgPop;
	public Button botonContinuar;
	public GameObject popInicioGO;
	public CuentaAtras cuentaAtrasScript;

	public void CierroPop()
	{
		cuentaAtrasScript.IniciarCuentaAtras();
		BGpop.CrossFadeAlpha(0,0.3f,false);
		imgPop.CrossFadeAlpha(0,0.3f,false);
		botonContinuar.gameObject.SetActive(false);
	}

}

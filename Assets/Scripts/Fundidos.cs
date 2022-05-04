using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Fundidos : MonoBehaviour {

	public Image imagenFundido;
	// Use this for initialization
	void Start () {
		// Fundo la imagen que cubre la pantalla de negro
		imagenFundido.CrossFadeAlpha(0,0.5f,false);
	}

}

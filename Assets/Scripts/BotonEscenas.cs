using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BotonEscenas : MonoBehaviour {

	// Declaro las variables y todos los objetos que voy a utilizar
	public Image fundido;


	//COMPRUEBO QUE HAY UN CLCIK EN EL BoxCollider2D
	void OnMouseDown()
	{
		this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.3f,0.3f,0.3f,1);
		this.gameObject.GetComponent<AudioSource>().Play();
	}
	//COMPRUEBO QUE el raton pasa por encima EN EL BoxCollider2D
	void OnMouseOver()
	{
		this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.5f,0.5f,0.5f,1);
	}
	//COMPRUEBO QUE el raton salio EN EL BoxCollider2D
	void OnMouseExit()
	{
		this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1,1,1,1);
	}
	//COMPRUEBO QUE se ha levantado el boton del click EN EL BoxCollider2D
	void OnMouseUp()
	{
		this.gameObject.GetComponent<SpriteRenderer>().color = new Color(1,1,1,1);
		this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
		fundido.CrossFadeAlpha(1,0.5f,false);
		StartCoroutine(CargoEscena());
	}

	// CORRUTINA secuenciada con wait for seconds
	IEnumerator CargoEscena()

	{
		yield return new WaitForSeconds (1);
		Application.LoadLevel("Juego");
	}





}












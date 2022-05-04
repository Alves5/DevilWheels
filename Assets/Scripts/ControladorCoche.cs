using UnityEngine;
using System.Collections;

public class ControladorCoche : MonoBehaviour {

	// Declaro las variables y todos los objetos que voy a utilizar
	public GameObject Coche;
	public float velocidadMovimientoCoche;
	public float anguloDeGiro;
	//float factor = 3;

	
	// UTILIZO FIXUPDATE estoy moviendo un componente rigidbody que choca con autos rigidos
	void FixedUpdate()
	{
		// el giro en cero
		float giroEnEjeZ = 0;

		// teclas left y right afectan al coche
		transform.Translate(Vector3.right * 
		                    Input.GetAxis("Horizontal")*
		                    velocidadMovimientoCoche *
		                    Time.deltaTime
		                    );

		// Calculo el giro left y right multiplicando el angulo de rotacion
		giroEnEjeZ = Input.GetAxis("Horizontal")* -anguloDeGiro;
		Coche.transform.rotation = Quaternion.Euler(0,0,giroEnEjeZ);


		// COmpruebo que el coche no salga de panatalña
		if (Coche.transform.position.y < -4.3f || Coche.transform.position.x < -10.0f
		    || Coche.transform.position.x >10)
		{
			ResetPosition();
		}

	}

	// funcion que posiciona el coche otra vez en su inicio
	void ResetPosition()
	{
		Coche.transform.position = new Vector3(0f,-2.4f,0f);
	}
}











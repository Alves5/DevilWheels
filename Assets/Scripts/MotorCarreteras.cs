using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorCarreteras : MonoBehaviour
{
    public GameObject motorCarreteras;
    public GameObject[] contenedorCalles;

    public float speed;
    
    public int numSelectorDeCalle;
    public int contadorCalles = 0;

    public bool cuentaRegresivaTermino;
    public bool juegoTerminado;
    // Start is called before the first frame update
    void Start()
    {
        juegoTerminado = false;
    }

    public void InicioJuego(){
      CreaCalles();
      SpeedCarretera();
      cuentaRegresivaTermino = false;
    }

    // Update is called once per frame
    void Update()
    {
      if(cuentaRegresivaTermino && juegoTerminado == false)
      {
        motorCarreteras.transform.Translate(Vector3.down * speed * Time.deltaTime);
      }
      
    }

    public void CreaCalles(){
      numSelectorDeCalle = Random.Range(0,5);
      GameObject Calle = (GameObject)Instantiate(contenedorCalles[numSelectorDeCalle],
                                                      new Vector3(0,50,0),
                                                      transform.rotation);
      Calle.SetActive(true);
      contadorCalles ++;
      Calle.name = "Calle"+contadorCalles;
      Calle.transform.parent = motorCarreteras.transform;

      GameObject piezaAux = GameObject.Find("Calle"+(contadorCalles-1));
      Calle.transform.position = new Vector3(transform.position.x,
                                  piezaAux.GetComponent<Renderer>().bounds.size.y +
                                  piezaAux.transform.position.y,
                                  piezaAux.transform.position.z);
    }
    public void SpeedStop(){
      speed = 0;
    }
    public void SpeedArcen(){
      speed = 5;
    }
    public void SpeedCarretera(){
      speed = 15;
    }
    public void SpeedCocheMalo(){
      speed = 3;
    }
    public void SpeedFinalizarJuego(){
      SpeedStop();
    }
}

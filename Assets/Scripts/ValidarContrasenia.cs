using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContrasenia : MonoBehaviour {

    string contraseniaCorrecta;
    string contraseniaUsr;
    public Text inputUsr;
    public Text textoMsj;
    public GameObject cartelitoMsj;
	
    // Use this for initialization
	void Start () {
        contraseniaCorrecta = "12345";
        cartelitoMsj.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void validarContrasenia()
    {
        contraseniaUsr = inputUsr.text;
        if (contraseniaUsr == contraseniaCorrecta)
        {
            cartelitoMsj.SetActive(true);
            textoMsj.text = "Bienvenido!";
        } else
        {
            cartelitoMsj.SetActive(true);
            textoMsj.text = "Contraseña incorrecta";
        }

    }
}

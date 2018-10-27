using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ControladorResultado : MonoBehaviour {

    public TextMeshProUGUI textoAcertos;

	// Use this for initialization
	void Start () {
        textoAcertos.text = ControleDeAcertos.QuestoesAcertadas.ToString();
            
	}
	public void refazer()
    {
        SceneManager.LoadScene("CenaQuiz");
    }
	// Update is called once per frame
	void Update () {
		
	}
}

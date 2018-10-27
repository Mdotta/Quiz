using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IniciarQuiz : MonoBehaviour {

    public void FazerQuiz()
    {
        SceneManager.LoadScene("CenaQuiz");
    }
}

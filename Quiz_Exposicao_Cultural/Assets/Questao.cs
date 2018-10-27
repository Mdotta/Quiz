using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Questao", menuName = "Questao", order = 1)]
public class Questao : ScriptableObject {

    public string TextoQuestao = "Qual é a nova questão?";
    public Alternativa[] Alternativas = new Alternativa[4];

  

}

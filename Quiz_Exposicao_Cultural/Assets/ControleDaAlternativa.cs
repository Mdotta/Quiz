using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ControleDaAlternativa : MonoBehaviour {

    Alternativa alternativaBotao;
    public TextMeshProUGUI textoAlternativa;

    public void AtualizarAlternativa(Alternativa novaAlternativa)
    {
        alternativaBotao = novaAlternativa;
        textoAlternativa.text = novaAlternativa.TextoAlternativa;
    }

    public void escolherAlternativa()
    {
        ControleDeQuestoes.self.ResponderQuestao(alternativaBotao);
    }
}

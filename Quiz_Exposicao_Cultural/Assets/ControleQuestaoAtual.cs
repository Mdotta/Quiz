using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ControleQuestaoAtual : MonoBehaviour {

    //instancia unica
    public static ControleQuestaoAtual self;

    public Questao QuestaoAtual;
    public ControleDaAlternativa[] controleDaAlternativaBotoes = new ControleDaAlternativa[4];
    public TextMeshProUGUI TextoQuestao;
	// Use this for initialization
    void Awake()
    {
        if (self == null)
        {
            self = this;
        }else
        {
            Destroy(gameObject);
        }
    }

	public void alterarQuestaoAtual(Questao novaQuestao)
    {
        QuestaoAtual = novaQuestao;
        AtualizarQuestaoExibida();
    }

    void AtualizarQuestaoExibida()
    {
        TextoQuestao.text = QuestaoAtual.TextoQuestao;
        for (int i = 0; i < QuestaoAtual.Alternativas.Length; i++)
        {
            controleDaAlternativaBotoes[i].AtualizarAlternativa(QuestaoAtual.Alternativas[i]);
        }
    }
}

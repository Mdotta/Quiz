using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;

public class ControleDeQuestoes : MonoBehaviour {

    public static ControleDeQuestoes self;
    public Questao[] PossiveisQuestoes;
    public List<Questao> QuestoesDoJogoAtual;
    public int QuantidadeDeQuestoes;
    int QuestaoAtual = -1;
	void Start () {
		if(self == null)
        {
            self = this;
        }
        else
        {
            Destroy(gameObject);
        }
        Reset();
	}
	
    void Reset()
    {
        ControleDeAcertos.QuestoesAcertadas = 0;
        QuestaoAtual = -1;
        SelecionarQuestoes();
    }

	void SelecionarQuestoes()
    {
        QuestoesDoJogoAtual = new List<Questao>();
        int i = 0;
        List<Questao> TodasAsQuestoesPossiveis = PossiveisQuestoes.ToList();
        while (i < QuantidadeDeQuestoes)
        {
            int indexNovo = Random.Range(0, TodasAsQuestoesPossiveis.Count);
            QuestoesDoJogoAtual.Add(TodasAsQuestoesPossiveis[indexNovo]);
            TodasAsQuestoesPossiveis.RemoveAt(indexNovo);
            i++;
        }
        AvancarQuestao();
    }

    void AvancarQuestao()
    {
        QuestaoAtual += 1;
        if(QuestaoAtual >= QuantidadeDeQuestoes)
        {
            TrocarTela();
        }
        else
        {
            ControleQuestaoAtual.self.alterarQuestaoAtual(QuestoesDoJogoAtual[QuestaoAtual]);
        }
    }

    void TrocarTela()
    {
        SceneManager.LoadScene("CenaResultado");
    }

    public void ResponderQuestao(Alternativa alternativaRespondida)
    {
        if (alternativaRespondida.EstaCerto)
        {
            ControleDeAcertos.QuestoesAcertadas += 1;

        }
        ControleDeQuestoes.self.AvancarQuestao();
    }
}

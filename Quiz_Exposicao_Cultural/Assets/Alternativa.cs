using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Alternativa
{
    public string TextoAlternativa = "";
    public bool EstaCerto = false;


    public Alternativa(string textoAlternativa, bool estaCerto)
    {
        this.TextoAlternativa = textoAlternativa;
        this.EstaCerto = estaCerto;
    }

    public Alternativa()
    {
        this.TextoAlternativa = "";
        this.EstaCerto = false;
    }
}

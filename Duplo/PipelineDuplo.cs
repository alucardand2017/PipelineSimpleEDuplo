using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace AUA12PIPELINE.duplo;

public class PipelineDuplo<T>
{
    private List<IEtapaDupla<T>> etapas = new List<IEtapaDupla<T>>();

    public PipelineDuplo<T> AdicionaEtapa(IEtapaDupla<T> etapa)
    {
        etapas.Add(etapa);
        return this;
    } 

    public T Processar(T entrada)
    {
     for (int i = 0 ; i < etapas.Count -1 ; i++)
     {
        etapas[i].ProximaEtapa = etapas[i+1];
     }
    return etapas[0].Processar(entrada);
    }
    
}
using System.Collections.Generic;
using System.Text;

namespace AUA12PIPELINE.SIMPLES;

public class Pipeline<T>
{
    private List<IEtapa<T>> etapas = new List<IEtapa<T>>();

    public Pipeline<T> AdicionaEtapa(IEtapa<T> etapa)
    {
        etapas.Add(etapa);
        return this;
    } 

    public T Processar(T entrada)
    {
        foreach(var etapa in etapas)
        {
            entrada = etapa.Processar(entrada);
        }
        return entrada;
    }
}
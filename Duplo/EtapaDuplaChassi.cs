using System.Text;
namespace AUA12PIPELINE.duplo;



public class EtapaDuplaChassi: IEtapaDupla<StringBuilder>
{
    public IEtapaDupla<StringBuilder> ProximaEtapa {get;set;} 

    public StringBuilder Processar(StringBuilder entrada)
    {
        entrada.Append("[CHASSI]");
        entrada = ProximaEtapa?.Processar(entrada) ?? entrada;
        return entrada;
    }
}
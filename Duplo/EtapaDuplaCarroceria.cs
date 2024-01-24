using System.Text;
namespace AUA12PIPELINE.duplo;

public class EtapaDuplaCarroceria: IEtapaDupla<StringBuilder>
{
        public IEtapaDupla<StringBuilder> ProximaEtapa {get;set;} 

    public StringBuilder Processar(StringBuilder entrada)
    {
        entrada.Insert(0,"[CARROCERIA]", 1);
        entrada.Insert(entrada.Length, "[CARROCERIA]", 1);
        entrada = ProximaEtapa?.Processar(entrada) ?? entrada;
        return entrada;
    }
}

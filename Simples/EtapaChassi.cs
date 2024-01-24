using System.Text;
namespace AUA12PIPELINE.SIMPLES;



public class EtapaChassi: IEtapa<StringBuilder>
{
    public StringBuilder Processar(StringBuilder entrada)
    {
        entrada.Append("[CHASSI]");
        return entrada;
    }
}
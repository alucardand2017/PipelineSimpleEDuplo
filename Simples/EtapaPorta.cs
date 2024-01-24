using System.Text;
namespace AUA12PIPELINE.SIMPLES;

public class EtapaPorta: IEtapa<StringBuilder>
{
    public StringBuilder Processar(StringBuilder entrada)
    {
        entrada.Insert(0,"[PORTA]",2);
        entrada.Insert(entrada.Length, "[PORTA]", 2);
        return entrada;
    }
}
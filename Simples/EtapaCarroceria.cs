using System.Text;
namespace AUA12PIPELINE.SIMPLES;

public class EtapaCarroceria: IEtapa<StringBuilder>
{
    public StringBuilder Processar(StringBuilder entrada)
    {
        entrada.Insert(0,"[CARROCERIA]", 1);
        entrada.Insert(entrada.Length, "[CARROCERIA]", 1);
        return entrada;
    }
}
